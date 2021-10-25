## 执行栈、宏任务、微任务、渲染任务、requestAnimationFrame以及requestIdleCallback执行顺序



核心：JS的Event Loop或者叫事件循环机制

这里JS的执行流是怎样的  它怎么做到异步的？





整体执行顺序：

执行栈 -> 执行所有的微任务 -> check render检查是否需要渲染（达到浏览器的该渲染的帧率） -> 需要渲染：执行requestAnimationFrame -> 需要渲染：阻塞js引擎线程，切到渲染线程执行 -> check worker检查是否有worker任务 -> 离渲染还有时间，或timeout时间到了执行requestIdleCallback


![img](https://images2018.cnblogs.com/blog/698814/201809/698814-20180906144953689-838865376.jpg)

**JavaScript 是一门单线程语言，异步操作都是放到事件循环队列里面，等待主执行栈来执行的，并没有专门的异步执行线程**



