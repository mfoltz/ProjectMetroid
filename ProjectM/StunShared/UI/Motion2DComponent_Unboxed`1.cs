// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DComponent_Unboxed`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public struct Motion2DComponent_Unboxed<T> where T : unmanaged, UnityEngine.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasComponent;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Motion2DComponent_Unboxed_1_T_GameObject_0;
    public T Value;
    public NativeBoolean HasComponent;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 922765, RefRangeEnd = 922771, XrefRangeStart = 922758, XrefRangeEnd = 922765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DComponent_Unboxed<T> Create(GameObject go)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DComponent_Unboxed<T>.NativeMethodInfoPtr_Create_Public_Static_Motion2DComponent_Unboxed_1_T_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Motion2DComponent_Unboxed<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Motion2DComponent_Unboxed()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", "Motion2DComponent`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr);
      Motion2DComponent_Unboxed<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr, nameof (Value));
      Motion2DComponent_Unboxed<T>.NativeFieldInfoPtr_HasComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr, nameof (HasComponent));
      Motion2DComponent_Unboxed<T>.NativeMethodInfoPtr_Create_Public_Static_Motion2DComponent_Unboxed_1_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr, 100663822);
    }

    public Motion2DComponent<T> BoxIl2CppObject()
    {
      return new Motion2DComponent<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent_Unboxed<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
