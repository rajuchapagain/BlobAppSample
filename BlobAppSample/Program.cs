using Azure.Storage.Blobs;

string connectionString = "connection-string-goes here";
string containerName = "container-name-goes-here";
string blobName = "script.sql";
string filePath = @"...\script.sql";

BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
await blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob container downloaded");