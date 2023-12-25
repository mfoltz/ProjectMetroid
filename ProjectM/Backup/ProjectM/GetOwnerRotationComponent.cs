// Decompiled with JetBrains decompiler
// Type: ProjectM.GetOwnerRotationComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class GetOwnerRotationComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OnlyOnSpawn;
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSource;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetDegreesClockwise;
    private static readonly IntPtr NativeFieldInfoPtr_InverseRotation;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996369, XrefRangeEnd = 996375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetOwnerRotationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetOwnerRotationComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetOwnerRotationComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetOwnerRotationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetOwnerRotationComponent()
    {
      Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GetOwnerRotationComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr);
      GetOwnerRotationComponent.NativeFieldInfoPtr_OnlyOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, nameof (OnlyOnSpawn));
      GetOwnerRotationComponent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, nameof (Type));
      GetOwnerRotationComponent.NativeFieldInfoPtr_RotationSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, nameof (RotationSource));
      GetOwnerRotationComponent.NativeFieldInfoPtr_OffsetDegreesClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, nameof (OffsetDegreesClockwise));
      GetOwnerRotationComponent.NativeFieldInfoPtr_InverseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, nameof (InverseRotation));
      GetOwnerRotationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, 100677004);
      GetOwnerRotationComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, 100677005);
      GetOwnerRotationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerRotationComponent>.NativeClassPtr, 100677006);
    }

    public GetOwnerRotationComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool OnlyOnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_OnlyOnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_OnlyOnSpawn)) = value;
      }
    }

    public unsafe GetRotationType Type
    {
      get
      {
        return *(GetRotationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(GetRotationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe GetOwnerRotationComponent.GetRotationSource RotationSource
    {
      get
      {
        return *(GetOwnerRotationComponent.GetRotationSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_RotationSource));
      }
      [param: In] set
      {
        *(GetOwnerRotationComponent.GetRotationSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_RotationSource)) = value;
      }
    }

    public unsafe float OffsetDegreesClockwise
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_OffsetDegreesClockwise));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_OffsetDegreesClockwise)) = value;
      }
    }

    public unsafe bool InverseRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_InverseRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerRotationComponent.NativeFieldInfoPtr_InverseRotation)) = value;
      }
    }

    public enum GetRotationSource
    {
      Owner,
      Creator,
      BuffTarget,
      None,
    }
  }
}
