// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkSnapshotData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkSnapshotData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_Il2CppReferenceArray_1_Type_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789720, XrefRangeEnd = 789722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkSnapshotData(
      NetworkSnapshotType snapshotType,
      Il2CppReferenceArray<Il2CppSystem.Type> componentTypes)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &snapshotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSnapshotData.NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkSnapshotData()
    {
      Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkSnapshotData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr);
      NetworkSnapshotData.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr, nameof (SnapshotType));
      NetworkSnapshotData.NativeFieldInfoPtr_ComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr, nameof (ComponentTypes));
      NetworkSnapshotData.NativeMethodInfoPtr__ctor_Public_Void_NetworkSnapshotType_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSnapshotData>.NativeClassPtr, 100669469);
    }

    public NetworkSnapshotData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkSnapshotType SnapshotType
    {
      get
      {
        return *(NetworkSnapshotType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkSnapshotData.NativeFieldInfoPtr_SnapshotType));
      }
      [param: In] set
      {
        *(NetworkSnapshotType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkSnapshotData.NativeFieldInfoPtr_SnapshotType)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Type> ComponentTypes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkSnapshotData.NativeFieldInfoPtr_ComponentTypes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NetworkSnapshotData.NativeFieldInfoPtr_ComponentTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
