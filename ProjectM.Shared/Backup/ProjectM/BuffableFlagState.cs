// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffableFlagState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffableFlagState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAnySet_Public_Boolean_BuffModificationTypes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_BuffModificationTypes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNotSet_Public_Boolean_BuffModificationTypes_0;
    [FieldOffset(0)]
    public ModifiableLong Value;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 736854, RefRangeEnd = 736864, XrefRangeStart = 736853, XrefRangeEnd = 736854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAnySet(BuffModificationTypes type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffableFlagState.NativeMethodInfoPtr_IsAnySet_Public_Boolean_BuffModificationTypes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(63)]
    [CachedScanResults(RefRangeStart = 736865, RefRangeEnd = 736928, XrefRangeStart = 736864, XrefRangeEnd = 736865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSet(BuffModificationTypes type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffableFlagState.NativeMethodInfoPtr_IsSet_Public_Boolean_BuffModificationTypes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 736929, RefRangeEnd = 736942, XrefRangeStart = 736928, XrefRangeEnd = 736929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsNotSet(BuffModificationTypes type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffableFlagState.NativeMethodInfoPtr_IsNotSet_Public_Boolean_BuffModificationTypes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BuffableFlagState()
    {
      Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffableFlagState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr);
      BuffableFlagState.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr, nameof (Value));
      BuffableFlagState.NativeMethodInfoPtr_IsAnySet_Public_Boolean_BuffModificationTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr, 100665075);
      BuffableFlagState.NativeMethodInfoPtr_IsSet_Public_Boolean_BuffModificationTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr, 100665076);
      BuffableFlagState.NativeMethodInfoPtr_IsNotSet_Public_Boolean_BuffModificationTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr, 100665077);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffableFlagState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
