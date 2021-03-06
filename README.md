# TensorFlow.NET
TensorFlow.NET provides .NET Standard binding for [TensorFlow](https://www.tensorflow.org/).

[![Join the chat at https://gitter.im/publiclab/publiclab](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/sci-sharp/community)
![Tensorflow.NET](https://ci.appveyor.com/api/projects/status/tensorflow-net-p7kmsjyo10ey?svg=true)

TensorFlow.NET is a member project of SciSharp stack.

![tensors_flowing](docs/assets/tensors_flowing.gif)

### How to use
Download the pre-compiled dll [here](tensorflowlib) and place it in the bin folder.

Import tensorflow.net.
```cs
using Tensorflow;
```

Add two constants.
```cs
// Create a Constant op
var a = tf.constant(4.0f);
var b = tf.constant(5.0f);
var c = tf.add(a, b);

using (var sess = tf.Session())
{
    var o = sess.run(c);
}
```

Feed placeholder.
```cs
// Create a placeholder op
var a = tf.placeholder(tf.float32);
var b = tf.placeholder(tf.float32);
var c = tf.add(a, b);

using(var sess = tf.Session())
{
    var feed_dict = new Dictionary<Tensor, object>();
    feed_dict.Add(a, 3.0f);
    feed_dict.Add(b, 2.0f);

    var o = sess.run(c, feed_dict);
}
```
