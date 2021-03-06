﻿using CG.Web.MegaApiClient.Tests.Context;
using Xunit;
using Xunit.Abstractions;

namespace CG.Web.MegaApiClient.Tests
{
  [Collection("AnonymousLoginTests")]
  public class DownloadUploadAnonymous : DownloadUpload
  {
    public DownloadUploadAnonymous(AnonymousTestContext context, ITestOutputHelper testOutputHelper)
      : base(context, testOutputHelper)
    {
    }
  }
}
