// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningConsumerAuthoring
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
namespace ProjectM.LightningStorm
{
  public class LightningConsumerAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ShouldReplaceLightningStrike;
    private static readonly IntPtr NativeFieldInfoPtr_ReplaceLightningStrikePrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ReplacePrefabIgnoreCollision;
    private static readonly IntPtr NativeFieldInfoPtr_ConsumeRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AlterPosition;
    private static readonly IntPtr NativeFieldInfoPtr_SetConsumerAsOwner;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114696, XrefRangeEnd = 1114700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LightningConsumerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114700, XrefRangeEnd = 1114701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningConsumerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningConsumerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningConsumerAuthoring()
    {
      Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningConsumerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr);
      LightningConsumerAuthoring.NativeFieldInfoPtr_ShouldReplaceLightningStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (ShouldReplaceLightningStrike));
      LightningConsumerAuthoring.NativeFieldInfoPtr_ReplaceLightningStrikePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (ReplaceLightningStrikePrefab));
      LightningConsumerAuthoring.NativeFieldInfoPtr_ReplacePrefabIgnoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (ReplacePrefabIgnoreCollision));
      LightningConsumerAuthoring.NativeFieldInfoPtr_ConsumeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (ConsumeRadius));
      LightningConsumerAuthoring.NativeFieldInfoPtr_AlterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (AlterPosition));
      LightningConsumerAuthoring.NativeFieldInfoPtr_SetConsumerAsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, nameof (SetConsumerAsOwner));
      LightningConsumerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, 100688247);
      LightningConsumerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningConsumerAuthoring>.NativeClassPtr, 100688248);
    }

    public LightningConsumerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool ShouldReplaceLightningStrike
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ShouldReplaceLightningStrike));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ShouldReplaceLightningStrike)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> ReplaceLightningStrikePrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ReplaceLightningStrikePrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ReplaceLightningStrikePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ReplacePrefabIgnoreCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ReplacePrefabIgnoreCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ReplacePrefabIgnoreCollision)) = value;
      }
    }

    public unsafe float ConsumeRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ConsumeRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_ConsumeRadius)) = value;
      }
    }

    public unsafe bool AlterPosition
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_AlterPosition));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_AlterPosition)) = value;
      }
    }

    public unsafe bool SetConsumerAsOwner
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_SetConsumerAsOwner));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningConsumerAuthoring.NativeFieldInfoPtr_SetConsumerAsOwner)) = value;
      }
    }
  }
}
