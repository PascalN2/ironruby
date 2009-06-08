﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * ironruby@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Runtime.CompilerServices;
using IronRuby.Builtins;

namespace IronRuby.Runtime.Calls {
    public abstract partial class MethodDispatcher {
        internal const int /*$$*/PrecompiledParameterCount = 5;

        private static readonly Type[] SingletonMethodDispatchers = new[] {
#if GENERATOR
            def generate; add_generic_types($PrecompiledParameterCount); end
#else
            typeof(SingletonMethodDispatcher<>),
#endif
#region Generated by MethodDispatcher.Generator.rb
            typeof(SingletonMethodDispatcher<,>),
            typeof(SingletonMethodDispatcher<,,>),
            typeof(SingletonMethodDispatcher<,,,>),
            typeof(SingletonMethodDispatcher<,,,,>),
#endregion
        };

        private static readonly Type[] SingletonMethodDispatchersWithScope = new[] {
#if GENERATOR
            def generate; add_generic_types($PrecompiledParameterCount); end
#else
            typeof(SingletonMethodDispatcherWithScope<>),
#endif
#region Generated by MethodDispatcher.Generator.rb
            typeof(SingletonMethodDispatcherWithScope<,>),
            typeof(SingletonMethodDispatcherWithScope<,,>),
            typeof(SingletonMethodDispatcherWithScope<,,,>),
            typeof(SingletonMethodDispatcherWithScope<,,,,>),
#endregion
        };

        private static readonly Type[] RubyObjectMethodDispatchers = new[] {
#if GENERATOR
            def generate; add_generic_types($PrecompiledParameterCount); end
#else
            typeof(RubyObjectMethodDispatcher<>),
#endif
#region Generated by MethodDispatcher.Generator.rb
            typeof(RubyObjectMethodDispatcher<,>),
            typeof(RubyObjectMethodDispatcher<,,>),
            typeof(RubyObjectMethodDispatcher<,,,>),
            typeof(RubyObjectMethodDispatcher<,,,,>),
#endregion
        };

        private static readonly Type[] RubyObjectMethodDispatchersWithScope = new[] {
#if GENERATOR
            def generate; add_generic_types($PrecompiledParameterCount); end
#else
            typeof(RubyObjectMethodDispatcherWithScope<>),
#endif
#region Generated by MethodDispatcher.Generator.rb
            typeof(RubyObjectMethodDispatcherWithScope<,>),
            typeof(RubyObjectMethodDispatcherWithScope<,,>),
            typeof(RubyObjectMethodDispatcherWithScope<,,,>),
            typeof(RubyObjectMethodDispatcherWithScope<,,,,>),
#endregion
        };
    }

#if GENERATOR
    def generate
      $PrecompiledParameterCount.times { |n| @n = n + 1; super }
    end

    def GenericDecl
      "<" + Array.new(@n) { |i| "T#{i}" }.join(", ") + ">"
    end

    def GenericParams
      Array.new(@n) { |i| "T#{i}," }.join(" ")
    end

    def Objects *args
      ", object" * @n
    end

    def Parameters
      "," + Array.new(@n) { |i| "T#{i} arg#{i}" }.join(", ") 
    end

    def Arguments
      "," + Array.new(@n) { |i| "arg#{i}" }.join(", ") 
    end
#else
    public class RubyObjectMethodDispatcher/*$GenericDecl*/ : MethodDispatcher<Func<object, Proc, object/*$Objects*/>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, /*$GenericParams*/ object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self /*$Parameters*/) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null /*$Arguments*/);
            } else {
                return ((CallSite<Func<CallSite, object, /*$GenericParams*/ object>>)callSite).
                    Update(callSite, self /*$Arguments*/);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope/*$GenericDecl*/ : MethodDispatcher<Func<object, Proc, object/*$Objects*/>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, /*$GenericParams*/ object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self /*$Parameters*/) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null /*$Arguments*/);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, /*$GenericParams*/ object>>)callSite).
                    Update(callSite, scope, self /*$Arguments*/);
            }
        }
    }

    public class SingletonMethodDispatcher/*$GenericDecl*/ : SingletonMethodDispatcherBase<Func<object, Proc, object/*$Objects*/>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, /*$GenericParams*/ object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self /*$Parameters*/) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null /*$Arguments*/);
            } else {
                return ((CallSite<Func<CallSite, object, /*$GenericParams*/ object>>)callSite).
                    Update(callSite, self /*$Arguments*/);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope/*$GenericDecl*/ : SingletonMethodDispatcherBase<Func<object, Proc, object/*$Objects*/>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,/*$GenericParams*/ object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self /*$Parameters*/) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null /*$Arguments*/);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, /*$GenericParams*/ object>>)callSite).
                    Update(callSite, scope, self /*$Arguments*/);
            }
        }
    }
#endif
#region Generated by MethodDispatcher.Generator.rb
    public class RubyObjectMethodDispatcher<T0> : MethodDispatcher<Func<object, Proc, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0);
            } else {
                return ((CallSite<Func<CallSite, object, T0, object>>)callSite).
                    Update(callSite, self ,arg0);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope<T0> : MethodDispatcher<Func<object, Proc, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, T0, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, object>>)callSite).
                    Update(callSite, scope, self ,arg0);
            }
        }
    }

    public class SingletonMethodDispatcher<T0> : SingletonMethodDispatcherBase<Func<object, Proc, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0);
            } else {
                return ((CallSite<Func<CallSite, object, T0, object>>)callSite).
                    Update(callSite, self ,arg0);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope<T0> : SingletonMethodDispatcherBase<Func<object, Proc, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,T0, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, object>>)callSite).
                    Update(callSite, scope, self ,arg0);
            }
        }
    }
    public class RubyObjectMethodDispatcher<T0, T1> : MethodDispatcher<Func<object, Proc, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, object>>)callSite).
                    Update(callSite, self ,arg0, arg1);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope<T0, T1> : MethodDispatcher<Func<object, Proc, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, T0, T1, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1);
            }
        }
    }

    public class SingletonMethodDispatcher<T0, T1> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, object>>)callSite).
                    Update(callSite, self ,arg0, arg1);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope<T0, T1> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,T0, T1, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1);
            }
        }
    }
    public class RubyObjectMethodDispatcher<T0, T1, T2> : MethodDispatcher<Func<object, Proc, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope<T0, T1, T2> : MethodDispatcher<Func<object, Proc, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, T0, T1, T2, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2);
            }
        }
    }

    public class SingletonMethodDispatcher<T0, T1, T2> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope<T0, T1, T2> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,T0, T1, T2, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2);
            }
        }
    }
    public class RubyObjectMethodDispatcher<T0, T1, T2, T3> : MethodDispatcher<Func<object, Proc, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, T3, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, T3, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2, arg3);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope<T0, T1, T2, T3> : MethodDispatcher<Func<object, Proc, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, T0, T1, T2, T3, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, T3, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2, arg3);
            }
        }
    }

    public class SingletonMethodDispatcher<T0, T1, T2, T3> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, T3, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, T3, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2, arg3);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope<T0, T1, T2, T3> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,T0, T1, T2, T3, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, T3, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2, arg3);
            }
        }
    }
    public class RubyObjectMethodDispatcher<T0, T1, T2, T3, T4> : MethodDispatcher<Func<object, Proc, object, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, T3, T4, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3, arg4);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, T3, T4, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2, arg3, arg4);
            }
        }
    }

    public class RubyObjectMethodDispatcherWithScope<T0, T1, T2, T3, T4> : MethodDispatcher<Func<object, Proc, object, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object, T0, T1, T2, T3, T4, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            IRubyObject obj = self as IRubyObject;
            if (obj != null && obj.ImmediateClass.Version.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3, arg4);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, T3, T4, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2, arg3, arg4);
            }
        }
    }

    public class SingletonMethodDispatcher<T0, T1, T2, T3, T4> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, object, T0, T1, T2, T3, T4, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3, arg4);
            } else {
                return ((CallSite<Func<CallSite, object, T0, T1, T2, T3, T4, object>>)callSite).
                    Update(callSite, self ,arg0, arg1, arg2, arg3, arg4);
            }
        }
    }

    public class SingletonMethodDispatcherWithScope<T0, T1, T2, T3, T4> : SingletonMethodDispatcherBase<Func<object, Proc, object, object, object, object, object, object>> {
        public override object/*!*/ CreateDelegate() {
            return new Func<CallSite, RubyScope, object,T0, T1, T2, T3, T4, object>(Invoke);
        }

        public object Invoke(CallSite/*!*/ callSite, RubyScope/*!*/ scope, object self ,T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
            if (self == Singleton && VersionHandle.Value == Version) {
                return Method(self, null ,arg0, arg1, arg2, arg3, arg4);
            } else {
                return ((CallSite<Func<CallSite, RubyScope, object, T0, T1, T2, T3, T4, object>>)callSite).
                    Update(callSite, scope, self ,arg0, arg1, arg2, arg3, arg4);
            }
        }
    }
#endregion

}
