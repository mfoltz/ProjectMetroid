// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceDebuggingSingleton
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
  public struct PersistenceDebuggingSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Flags;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TestOnSave_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StoreExtraDebugData_Public_get_Boolean_0;
    [FieldOffset(0)]
    public PersistenceDebugFlags Flags;

    public unsafe bool TestOnSave
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 735454, RefRangeEnd = 735458, XrefRangeStart = 735454, XrefRangeEnd = 735454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceDebuggingSingleton.NativeMethodInfoPtr_get_TestOnSave_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool StoreExtraDebugData
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 735458, RefRangeEnd = 735469, XrefRangeStart = 735458, XrefRangeEnd = 735458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceDebuggingSingleton.NativeMethodInfoPtr_get_StoreExtraDebugData_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PersistenceDebuggingSingleton()
    {
      Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PersistenceDebuggingSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr);
      PersistenceDebuggingSingleton.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr, nameof (Flags));
      PersistenceDebuggingSingleton.NativeMethodInfoPtr_get_TestOnSave_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr, 100664936);
      PersistenceDebuggingSingleton.NativeMethodInfoPtr_get_StoreExtraDebugData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr, 100664937);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceDebuggingSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
