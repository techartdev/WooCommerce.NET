using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using WooCommerce.NET;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WordPress.v2
{
    public class WpObject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        where T1 : Posts where T2 : PostRevisions where T3 : Categories where T4 : Tags where T5 : Pages where T6 : Comments
        where T7 : Taxonomies where T8 : Media where T9 : Users where T10 : PostTypes where T11 : PostStatuses where T12 : Settings
    {
       
        protected RestApi API { get; set; }
        public WpObject(RestApi api)
        {
            API = api;

            Post = new WpPostItem(api);
            Categories = new WcItem<T3>(api);
            Tags = new WcItem<T4>(api);
            Pages = new WcItem<T5>(api);
            Comments = new WcItem<T6>(api);
            Taxonomies = new WcItem<T7>(api);
            Media = new WPMediaItem(api);
            Users = new WcItem<T9>(api);
            PostTypes = new WcItem<T10>(api);
            PostStatuses = new WcItem<T11>(api);
            Settings = new WpSettingItem(api);
        }

        public WpPostItem Post { get; protected set; }

        public WcItem<T3> Categories { get; protected set; }

        public WcItem<T4> Tags { get; protected set; }

        public WcItem<T5> Pages { get; protected set; }

        public WcItem<T6> Comments { get; protected set; }

        public WcItem<T7> Taxonomies { get; protected set; }

        public WPMediaItem Media { get; protected set; }

        public WcItem<T9> Users { get; protected set; }

        public WcItem<T10> PostTypes { get; protected set; }

        public WcItem<T11> PostStatuses { get; protected set; }

        public WpSettingItem Settings { get; protected set; }

        public class WpPostItem : WcItem<T1>
        {
            public WpPostItem(RestApi api) : base(api)
            {
                Api = api;

                Revisions = new WcSubItem<T2>(api, ApiEndpoint);
            }

            public WcSubItem<T2> Revisions { get; set; }
        }

        public class WPMediaItem : WcItem<T8>
        {
            public WPMediaItem(RestApi api) : base(api)
            {
                Api = api;
            }

            public async Task<T8> Add(string fileName, string filePath)
            {
                Dictionary<string, string> ps = new Dictionary<string, string>();
                ps.Add("name", fileName);
                ps.Add("path", filePath);

                return Api.DeserializeJSon<T8>(await Api.PostRestful(ApiEndpoint, "fileupload", ps).ConfigureAwait(false));
            }
        }

        public class WpSettingItem : WcItem<T12>
        {
            public WpSettingItem(RestApi api) : base(api)
            {
                Api = api;
            }

            public async Task<T12> Get(Dictionary<string, string> parms = null)
            {
                return Api.DeserializeJSon<T12>(await Api.GetRestful(ApiEndpoint, parms).ConfigureAwait(false));
            }
        }
    }

    public class WpObject: WpObject<Posts, PostRevisions, Categories, Tags, Pages, Comments, Taxonomies, Media, Users, PostTypes, PostStatuses, Settings>
    {
        public WpObject(RestApi api) : base(api)
        {
        }
    }

    public class Plugins
    {
        public static string Endpoint => "plugins";
    }
}

namespace WooCommerce.NET.WordPress.v2.Extension
{
    public static class WpExtension
    {
        public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => tcs.TrySetResult(true)))
                if (task != await Task.WhenAny(task, tcs.Task))
                    throw new OperationCanceledException(cancellationToken);
            return await task;
        }

        public static async Task WithCancellation(this Task task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => tcs.TrySetResult(true)))
                if (task != await Task.WhenAny(task, tcs.Task))
                    throw new OperationCanceledException(cancellationToken);
            await task;
        }

    }
}