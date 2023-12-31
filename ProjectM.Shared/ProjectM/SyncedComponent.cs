// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncedComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class SyncedComponent : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentSource;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SyncedComponent_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730940, XrefRangeEnd = 730942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(SyncedComponent other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedComponent.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SyncedComponent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncedComponent()
    {
      Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SyncedComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr);
      SyncedComponent.NativeFieldInfoPtr_NetworkedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, nameof (NetworkedComponent));
      SyncedComponent.NativeFieldInfoPtr_ComponentSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, nameof (ComponentSource));
      SyncedComponent.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SyncedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, 100664601);
    }

    public SyncedComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SyncedComponent()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncedComponent>.NativeClassPtr, data));
    }

    public unsafe Il2CppSystem.Type NetworkedComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedComponent.NativeFieldInfoPtr_NetworkedComponent));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedComponent.NativeFieldInfoPtr_NetworkedComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string ComponentSource
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncedComponent.NativeFieldInfoPtr_ComponentSource)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncedComponent.NativeFieldInfoPtr_ComponentSource), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
