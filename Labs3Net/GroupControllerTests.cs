using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;
using DomainTables.Models;
//using Microsoft.VisualStudio.TestPlatform.TestHost;
using Labs3NetUniversityApi;

namespace Labs3Net
{
    public class GroupControllerTests : IClassFixture<CustomWebApplicationFactory<Labs3NetUniversityApi.Program>>
    {
        private readonly HttpClient _client;

        public GroupControllerTests(CustomWebApplicationFactory<Labs3NetUniversityApi.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CanCreateAndGetGroup()
        {
            var newGroup = new Group { Name = "Test Group", Year = 2024 };
            var postResponse = await _client.PostAsJsonAsync("/api/groups", newGroup);
            Assert.Equal(HttpStatusCode.Created, postResponse.StatusCode);

            var groups = await _client.GetFromJsonAsync<Group[]>("/api/groups");
            Assert.Contains(groups, g => g.Name == "Test Group");
        }

        [Fact]
        public async Task CanUpdateGroup()
        {
            var group = new Group { Name = "UpdateMe", Year = 2024 };
            var post = await _client.PostAsJsonAsync("/api/groups", group);
            var created = await post.Content.ReadFromJsonAsync<Group>();

            created.Name = "Updated Name";
            var put = await _client.PutAsJsonAsync($"/api/groups/{created.GroupId}", created);
            Assert.Equal(HttpStatusCode.NoContent, put.StatusCode);
        }

        [Fact]
        public async Task CanDeleteGroup()
        {
            var group = new Group { Name = "ToDelete", Year = 2024 };
            var post = await _client.PostAsJsonAsync("/api/groups", group);
            var created = await post.Content.ReadFromJsonAsync<Group>();

            var delete = await _client.DeleteAsync($"/api/groups/{created.GroupId}");
            Assert.Equal(HttpStatusCode.NoContent, delete.StatusCode);
        }
    }
}
