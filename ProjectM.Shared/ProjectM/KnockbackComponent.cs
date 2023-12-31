// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackComponent
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
  public class KnockbackComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726707, XrefRangeEnd = 726726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(KnockbackComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726726, XrefRangeEnd = 726733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KnockbackComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726733, XrefRangeEnd = 726734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KnockbackComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KnockbackComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KnockbackComponent()
    {
      Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr);
      KnockbackComponent.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, nameof (Speed));
      KnockbackComponent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, nameof (Range));
      KnockbackComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, nameof (Curve));
      KnockbackComponent.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, nameof (RotationMode));
      KnockbackComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, 100664251);
      KnockbackComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, 100664252);
      KnockbackComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackComponent>.NativeClassPtr, 100664253);
    }

    public KnockbackComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe MovementCurveRotationMode RotationMode
    {
      get
      {
        return *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_RotationMode));
      }
      [param: In] set
      {
        *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackComponent.NativeFieldInfoPtr_RotationMode)) = value;
      }
    }
  }
}
