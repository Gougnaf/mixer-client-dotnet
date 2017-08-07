using MixerClient.Models;
using System;
using Xunit;

namespace MixerClient.Tests
{
    public class UsersService
    {
        [Fact]
        public void ShouldGetTheCurrentUser()
        {
            MixerAPI mixer = new MixerAPI("oauthCode");
            MixerUser user = mixer.UsersService.GetCurrentAsync().Result;
            Assert.Equal(user.username, "Merlin");
        }
    }
}
