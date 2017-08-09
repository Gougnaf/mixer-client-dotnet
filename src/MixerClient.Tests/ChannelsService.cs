using MixerClient.Models.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MixerClient.Tests
{
    public class ChannelsService
    {
        [Fact]
        public void ShouldGetSegmentedChannels()
        {
            MixerAPI mixer = new MixerAPI();
            IEnumerable<MixerChannel> channels = mixer.ChannelsService.GetSegmentedAsync(0, 25).Result;
            Assert.Equal(25, channels.ToList().Count);
        }
    }
}
