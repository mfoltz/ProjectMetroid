// Decompiled with JetBrains decompiler
// Type: ProjectM.CanFlyComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CanFlyComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FlyingHeight;
    private static readonly IntPtr NativeFieldInfoPtr_VerticalSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_VerticalAcceleration;
    private static readonly IntPtr NativeFieldInfoPtr_HeightAboveObstacle;
    private static readonly IntPtr NativeFieldInfoPtr_ProximitySpeedModifier;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736946, XrefRangeEnd = 736951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CanFlyComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736951, XrefRangeEnd = 736955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CanFlyComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736955, XrefRangeEnd = 736956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CanFlyComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CanFlyComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CanFlyComponent()
    {
      Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CanFlyComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr);
      CanFlyComponent.NativeFieldInfoPtr_FlyingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, nameof (FlyingHeight));
      CanFlyComponent.NativeFieldInfoPtr_VerticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, nameof (VerticalSpeed));
      CanFlyComponent.NativeFieldInfoPtr_VerticalAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, nameof (VerticalAcceleration));
      CanFlyComponent.NativeFieldInfoPtr_HeightAboveObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, nameof (HeightAboveObstacle));
      CanFlyComponent.NativeFieldInfoPtr_ProximitySpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, nameof (ProximitySpeedModifier));
      CanFlyComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, 100665080);
      CanFlyComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, 100665081);
      CanFlyComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFlyComponent>.NativeClassPtr, 100665082);
    }

    public CanFlyComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float FlyingHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_FlyingHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_FlyingHeight)) = value;
      }
    }

    public unsafe float VerticalSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_VerticalSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_VerticalSpeed)) = value;
      }
    }

    public unsafe float VerticalAcceleration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_VerticalAcceleration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_VerticalAcceleration)) = value;
      }
    }

    public unsafe float HeightAboveObstacle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_HeightAboveObstacle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_HeightAboveObstacle)) = value;
      }
    }

    public unsafe CurveReference ProximitySpeedModifier
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_ProximitySpeedModifier));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFlyComponent.NativeFieldInfoPtr_ProximitySpeedModifier)) = value;
      }
    }
  }
}
