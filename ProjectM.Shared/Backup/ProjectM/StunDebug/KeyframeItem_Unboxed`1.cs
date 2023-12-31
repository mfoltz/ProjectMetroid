// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.KeyframeItem_Unboxed`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
namespace ProjectM.StunDebug
{
  [Serializable]
  public struct KeyframeItem_Unboxed<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Single_0;
    public T Value;
    public float Time;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770794, RefRangeEnd = 770795, XrefRangeStart = 770793, XrefRangeEnd = 770794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KeyframeItem_Unboxed(T value, float time)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (System.ValueType) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyframeItem_Unboxed<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KeyframeItem_Unboxed()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", "KeyframeItem`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr);
      KeyframeItem_Unboxed<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr, nameof (Value));
      KeyframeItem_Unboxed<T>.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr, nameof (Time));
      KeyframeItem_Unboxed<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr, 100668270);
    }

    public KeyframeItem<T> BoxIl2CppObject()
    {
      return new KeyframeItem<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyframeItem_Unboxed<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
