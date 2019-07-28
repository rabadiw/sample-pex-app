#nuget restore PexSampleAspNet/packages.config -PackagesDirectory packages
msbuild PexSampleAspNet/PexSampleAspNet.csproj `
    -t:"Clean;Build;Publish" `
    -p:TargetFrameworkVersion=v4.7.2 `
    -p:OutputPath="./bin/Release" `
    -p:Configuration=Release `
    -p:Platform=AnyCPU `
    -p:DeployOnBuild=true `
    -p:PublishDirectory="./bin/Release/Publish" `
    -p:PublishProfile=FolderProfile
