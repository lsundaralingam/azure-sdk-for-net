// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Rest service Sink. </summary>
    public partial class RestSink : CopySink
    {
        /// <summary> Initializes a new instance of RestSink. </summary>
        public RestSink()
        {
            Type = "RestSink";
        }

        /// <summary> Initializes a new instance of RestSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="requestMethod"> The HTTP method used to call the RESTful API. The default is POST. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalHeaders"> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </param>
        /// <param name="httpRequestTimeout"> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="requestInterval"> The time to await before sending next request, in milliseconds. </param>
        /// <param name="httpCompressionType"> Http Compression Type to Send data in compressed format with Optimal Compression Level, Default is None. And The Only Supported option is Gzip. </param>
        internal RestSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object requestMethod, object additionalHeaders, object httpRequestTimeout, object requestInterval, object httpCompressionType) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            RequestMethod = requestMethod;
            AdditionalHeaders = additionalHeaders;
            HttpRequestTimeout = httpRequestTimeout;
            RequestInterval = requestInterval;
            HttpCompressionType = httpCompressionType;
            Type = type ?? "RestSink";
        }

        /// <summary> The HTTP method used to call the RESTful API. The default is POST. Type: string (or Expression with resultType string). </summary>
        public object RequestMethod { get; set; }
        /// <summary> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </summary>
        public object AdditionalHeaders { get; set; }
        /// <summary> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object HttpRequestTimeout { get; set; }
        /// <summary> The time to await before sending next request, in milliseconds. </summary>
        public object RequestInterval { get; set; }
        /// <summary> Http Compression Type to Send data in compressed format with Optimal Compression Level, Default is None. And The Only Supported option is Gzip. </summary>
        public object HttpCompressionType { get; set; }
    }
}
