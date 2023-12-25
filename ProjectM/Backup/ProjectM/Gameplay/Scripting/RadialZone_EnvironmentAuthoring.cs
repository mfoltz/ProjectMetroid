// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.RadialZone_EnvironmentAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class RadialZone_EnvironmentAuthoring : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Debuff;
    private static readonly IntPtr NativeFieldInfoPtr_Spheres;
    private static readonly IntPtr NativeFieldInfoPtr_AdditionalRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AreaType;
    private static readonly IntPtr NativeFieldInfoPtr_EffectSequence;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117117, XrefRangeEnd = 1117147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117147, XrefRangeEnd = 1117185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117185, XrefRangeEnd = 1117191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RadialZone_EnvironmentAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RadialZone_EnvironmentAuthoring()
    {
      Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Gameplay.Scripting", nameof (RadialZone_EnvironmentAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr);
      RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Debuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (Debuff));
      RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Spheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (Spheres));
      RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AdditionalRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (AdditionalRadius));
      RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AreaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (AreaType));
      RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_EffectSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (EffectSequence));
      RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, 100688554);
      RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, 100688555);
      RadialZone_EnvironmentAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, 100688556);
    }

    public RadialZone_EnvironmentAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<BuffComponent> Debuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Debuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<BuffComponent>) null : new WeakAssetReference<BuffComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Debuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RadialZone_EnvironmentAuthoring.EnvironmentSpheres Spheres
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Spheres));
        return pointer == IntPtr.Zero ? (RadialZone_EnvironmentAuthoring.EnvironmentSpheres) null : new RadialZone_EnvironmentAuthoring.EnvironmentSpheres(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_Spheres), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AdditionalRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AdditionalRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AdditionalRadius)) = value;
      }
    }

    public unsafe HazardAreaType AreaType
    {
      get
      {
        return *(HazardAreaType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AreaType));
      }
      [param: In] set
      {
        *(HazardAreaType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_AreaType)) = value;
      }
    }

    public unsafe SequenceField EffectSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_EffectSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RadialZone_EnvironmentAuthoring.NativeFieldInfoPtr_EffectSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class EnvironmentSpheres : ReorderableArray<Environment_HitSphere>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1117116, RefRangeEnd = 1117117, XrefRangeStart = 1117113, XrefRangeEnd = 1117116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EnvironmentSpheres()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring.EnvironmentSpheres>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RadialZone_EnvironmentAuthoring.EnvironmentSpheres.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EnvironmentSpheres()
      {
        Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring.EnvironmentSpheres>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring>.NativeClassPtr, nameof (EnvironmentSpheres));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring.EnvironmentSpheres>.NativeClassPtr);
        RadialZone_EnvironmentAuthoring.EnvironmentSpheres.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialZone_EnvironmentAuthoring.EnvironmentSpheres>.NativeClassPtr, 100688557);
      }

      public EnvironmentSpheres(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
