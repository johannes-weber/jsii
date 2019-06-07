using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <remarks>stability: Stable</remarks>
    [JsiiClass(nativeType: typeof(StableClass), fullyQualifiedName: "jsii-calc.StableClass", parametersJson: "[{\"name\":\"readonlyString\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"mutableNumber\",\"type\":{\"primitive\":\"number\"},\"optional\":true}]")]
    public class StableClass : DeputyBase
    {
        /// <remarks>stability: Stable</remarks>
        public StableClass(string readonlyString, double? mutableNumber): base(new DeputyProps(new object[]{readonlyString, mutableNumber}))
        {
        }

        protected StableClass(ByRefValue reference): base(reference)
        {
        }

        protected StableClass(DeputyProps props): base(props)
        {
        }

        /// <remarks>stability: Stable</remarks>
        [JsiiProperty(name: "readonlyProperty", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadonlyProperty
        {
            get => GetInstanceProperty<string>();
        }

        /// <remarks>stability: Stable</remarks>
        [JsiiProperty(name: "mutableProperty", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MutableProperty
        {
            get => GetInstanceProperty<double? >();
            set => SetInstanceProperty(value);
        }

        /// <remarks>stability: Stable</remarks>
        [JsiiMethod(name: "method")]
        public virtual void Method()
        {
            InvokeInstanceVoidMethod(new object[]{});
        }
    }
}