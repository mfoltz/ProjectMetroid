// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicCollisionSettingsAuthoring
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
  [Serializable]
  public class DynamicCollisionSettingsAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HardnessThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadiusOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadiusVariation;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToRuntime_Public_DynamicCollisionSettings_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006794, XrefRangeEnd = 1006797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicCollisionSettings ToRuntime(Entity entity, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicCollisionSettingsAuthoring.NativeMethodInfoPtr_ToRuntime_Public_DynamicCollisionSettings_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicCollisionSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006797, XrefRangeEnd = 1006798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicCollisionSettingsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicCollisionSettingsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DynamicCollisionSettingsAuthoring()
    {
      Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DynamicCollisionSettingsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr);
      DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_HardnessThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, nameof (HardnessThreshold));
      DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, nameof (PushStrengthMin));
      DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, nameof (PushStrengthMax));
      DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, nameof (RadiusOverride));
      DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, nameof (RadiusVariation));
      DynamicCollisionSettingsAuthoring.NativeMethodInfoPtr_ToRuntime_Public_DynamicCollisionSettings_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, 100678143);
      DynamicCollisionSettingsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicCollisionSettingsAuthoring>.NativeClassPtr, 100678144);
    }

    public DynamicCollisionSettingsAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float HardnessThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_HardnessThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_HardnessThreshold)) = value;
      }
    }

    public unsafe float PushStrengthMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMin)) = value;
      }
    }

    public unsafe float PushStrengthMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_PushStrengthMax)) = value;
      }
    }

    public unsafe float RadiusOverride
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusOverride));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusOverride)) = value;
      }
    }

    public unsafe float RadiusVariation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusVariation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicCollisionSettingsAuthoring.NativeFieldInfoPtr_RadiusVariation)) = value;
      }
    }
  }
}
