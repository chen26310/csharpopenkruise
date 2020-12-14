// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServicePort contains information on service's port.
    /// </summary>
    public partial class V1ServicePort
    {
        /// <summary>
        /// Initializes a new instance of the V1ServicePort class.
        /// </summary>
        public V1ServicePort()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ServicePort class.
        /// </summary>
        /// <param name="port">The port that will be exposed by this
        /// service.</param>
        /// <param name="appProtocol">The application protocol for this port.
        /// This field follows standard Kubernetes label syntax. Un-prefixed
        /// names are reserved for IANA standard service names (as per RFC-6335
        /// and http://www.iana.org/assignments/service-names). Non-standard
        /// protocols should use prefixed names such as
        /// mycompany.com/my-custom-protocol. This is a beta field that is
        /// guarded by the ServiceAppProtocol feature gate and enabled by
        /// default.</param>
        /// <param name="name">The name of this port within the service. This
        /// must be a DNS_LABEL. All ports within a ServiceSpec must have
        /// unique names. When considering the endpoints for a Service, this
        /// must match the 'name' field in the EndpointPort. Optional if only
        /// one ServicePort is defined on this service.</param>
        /// <param name="nodePort">The port on each node on which this service
        /// is exposed when type is NodePort or LoadBalancer.  Usually assigned
        /// by the system. If a value is specified, in-range, and not in use it
        /// will be used, otherwise the operation will fail.  If not specified,
        /// a port will be allocated if this Service requires one.  If this
        /// field is specified when creating a Service which does not need it,
        /// creation will fail. This field will be wiped when updating a
        /// Service to no longer need it (e.g. changing type from NodePort to
        /// ClusterIP). More info:
        /// https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport</param>
        /// <param name="protocol">The IP protocol for this port. Supports
        /// "TCP", "UDP", and "SCTP". Default is TCP.</param>
        /// <param name="targetPort">Number or name of the port to access on
        /// the pods targeted by the service. Number must be in the range 1 to
        /// 65535. Name must be an IANA_SVC_NAME. If this is a string, it will
        /// be looked up as a named port in the target Pod's container ports.
        /// If this is not specified, the value of the 'port' field is used (an
        /// identity map). This field is ignored for services with
        /// clusterIP=None, and should be omitted or set equal to the 'port'
        /// field. More info:
        /// https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service</param>
        public V1ServicePort(int port, string appProtocol = default(string), string name = default(string), int? nodePort = default(int?), string protocol = default(string), IntstrIntOrString targetPort = default(IntstrIntOrString))
        {
            AppProtocol = appProtocol;
            Name = name;
            NodePort = nodePort;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the application protocol for this port. This field
        /// follows standard Kubernetes label syntax. Un-prefixed names are
        /// reserved for IANA standard service names (as per RFC-6335 and
        /// http://www.iana.org/assignments/service-names). Non-standard
        /// protocols should use prefixed names such as
        /// mycompany.com/my-custom-protocol. This is a beta field that is
        /// guarded by the ServiceAppProtocol feature gate and enabled by
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "appProtocol")]
        public string AppProtocol { get; set; }

        /// <summary>
        /// Gets or sets the name of this port within the service. This must be
        /// a DNS_LABEL. All ports within a ServiceSpec must have unique names.
        /// When considering the endpoints for a Service, this must match the
        /// 'name' field in the EndpointPort. Optional if only one ServicePort
        /// is defined on this service.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the port on each node on which this service is exposed
        /// when type is NodePort or LoadBalancer.  Usually assigned by the
        /// system. If a value is specified, in-range, and not in use it will
        /// be used, otherwise the operation will fail.  If not specified, a
        /// port will be allocated if this Service requires one.  If this field
        /// is specified when creating a Service which does not need it,
        /// creation will fail. This field will be wiped when updating a
        /// Service to no longer need it (e.g. changing type from NodePort to
        /// ClusterIP). More info:
        /// https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport
        /// </summary>
        [JsonProperty(PropertyName = "nodePort")]
        public int? NodePort { get; set; }

        /// <summary>
        /// Gets or sets the port that will be exposed by this service.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the IP protocol for this port. Supports "TCP", "UDP",
        /// and "SCTP". Default is TCP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets number or name of the port to access on the pods
        /// targeted by the service. Number must be in the range 1 to 65535.
        /// Name must be an IANA_SVC_NAME. If this is a string, it will be
        /// looked up as a named port in the target Pod's container ports. If
        /// this is not specified, the value of the 'port' field is used (an
        /// identity map). This field is ignored for services with
        /// clusterIP=None, and should be omitted or set equal to the 'port'
        /// field. More info:
        /// https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service
        /// </summary>
        [JsonProperty(PropertyName = "targetPort")]
        public IntstrIntOrString TargetPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
