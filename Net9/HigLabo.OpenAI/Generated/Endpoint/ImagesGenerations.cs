﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    /// <summary>
    /// Creates an image given a prompt. Learn more.
    /// <seealso href="https://api.openai.com/v1/images/generations">https://api.openai.com/v1/images/generations</seealso>
    /// </summary>
    public partial class ImagesGenerationsParameter : RestApiParameter, IRestApiParameter
    {
        string IRestApiParameter.HttpMethod { get; } = "POST";
        /// <summary>
        /// A text description of the desired image(s). The maximum length is 32000 characters for gpt-image-1, 1000 characters for dall-e-2 and 4000 characters for dall-e-3.
        /// </summary>
        public string Prompt { get; set; } = "";
        /// <summary>
        /// Allows to set transparency for the background of the generated image(s). This parameter is only supported for gpt-image-1. Must be one of transparent, opaque or auto (default value). When auto is used, the model will automatically determine the best background for the image.
        /// If transparent, the output format needs to support transparency, so it should be set to either png (default value) or webp.
        /// </summary>
        public string? Background { get; set; }
        /// <summary>
        /// The model to use for image generation. One of dall-e-2, dall-e-3, or gpt-image-1. Defaults to dall-e-2 unless a parameter specific to gpt-image-1 is used.
        /// </summary>
        public string? Model { get; set; }
        /// <summary>
        /// Control the content-moderation level for images generated by gpt-image-1. Must be either low for less restrictive filtering or auto (default value).
        /// </summary>
        public string? Moderation { get; set; }
        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For dall-e-3, only n=1 is supported.
        /// </summary>
        public int? N { get; set; }
        /// <summary>
        /// The compression level (0-100%) for the generated images. This parameter is only supported for gpt-image-1 with the webp or jpeg output formats, and defaults to 100.
        /// </summary>
        public int? Output_Compression { get; set; }
        /// <summary>
        /// The format in which the generated images are returned. This parameter is only supported for gpt-image-1. Must be one of png, jpeg, or webp.
        /// </summary>
        public string? Output_Format { get; set; }
        /// <summary>
        /// The quality of the image that will be generated.
        /// auto (default value) will automatically select the best quality for the given model.
        /// high, medium and low are supported for gpt-image-1.
        /// hd and standard are supported for dall-e-3.
        /// standard is the only option for dall-e-2.
        /// </summary>
        public string? Quality { get; set; }
        /// <summary>
        /// The format in which generated images with dall-e-2 and dall-e-3 are returned. Must be one of url or b64_json. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for gpt-image-1 which will always return base64-encoded images.
        /// </summary>
        public string? Response_Format { get; set; }
        /// <summary>
        /// The size of the generated images. Must be one of 1024x1024, 1536x1024 (landscape), 1024x1536 (portrait), or auto (default value) for gpt-image-1, one of 256x256, 512x512, or 1024x1024 for dall-e-2, and one of 1024x1024, 1792x1024, or 1024x1792 for dall-e-3.
        /// </summary>
        public string? Size { get; set; }
        /// <summary>
        /// The style of the generated images. This parameter is only supported for dall-e-3. Must be one of vivid or natural. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.
        /// </summary>
        public string? Style { get; set; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. Learn more.
        /// </summary>
        public string? User { get; set; }

        string IRestApiParameter.GetApiPath()
        {
            return $"/images/generations";
        }
        public override object GetRequestBody()
        {
            return new {
            	prompt = this.Prompt,
            	background = this.Background,
            	model = this.Model,
            	moderation = this.Moderation,
            	n = this.N,
            	output_compression = this.Output_Compression,
            	output_format = this.Output_Format,
            	quality = this.Quality,
            	response_format = this.Response_Format,
            	size = this.Size,
            	style = this.Style,
            	user = this.User,
            };
        }
    }
    public partial class ImagesGenerationsResponse : RestApiDataResponse<List<ImageObject>>
    {
    }
    public partial class OpenAIClient
    {
        public async ValueTask<ImagesGenerationsResponse> ImagesGenerationsAsync(string prompt)
        {
            var p = new ImagesGenerationsParameter();
            p.Prompt = prompt;
            return await this.SendJsonAsync<ImagesGenerationsParameter, ImagesGenerationsResponse>(p, System.Threading.CancellationToken.None);
        }
        public async ValueTask<ImagesGenerationsResponse> ImagesGenerationsAsync(string prompt, CancellationToken cancellationToken)
        {
            var p = new ImagesGenerationsParameter();
            p.Prompt = prompt;
            return await this.SendJsonAsync<ImagesGenerationsParameter, ImagesGenerationsResponse>(p, cancellationToken);
        }
        public async ValueTask<ImagesGenerationsResponse> ImagesGenerationsAsync(ImagesGenerationsParameter parameter)
        {
            return await this.SendJsonAsync<ImagesGenerationsParameter, ImagesGenerationsResponse>(parameter, System.Threading.CancellationToken.None);
        }
        public async ValueTask<ImagesGenerationsResponse> ImagesGenerationsAsync(ImagesGenerationsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendJsonAsync<ImagesGenerationsParameter, ImagesGenerationsResponse>(parameter, cancellationToken);
        }
    }
}
