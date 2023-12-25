// Decompiled with JetBrains decompiler
// Type: ProjectM.AffectPrisonerWithToxicAuthoring
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
  public class AffectPrisonerWithToxicAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ChanceToBecomeMutant;
    private static readonly IntPtr NativeFieldInfoPtr_IncreaseBloodQuality_Min;
    private static readonly IntPtr NativeFieldInfoPtr_IncreaseBloodQuality_Max;
    private static readonly IntPtr NativeFieldInfoPtr_MutantType;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnBuff;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023968, XrefRangeEnd = 1023973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AffectPrisonerWithToxicAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AffectPrisonerWithToxicAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AffectPrisonerWithToxicAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AffectPrisonerWithToxicAuthoring()
    {
      Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AffectPrisonerWithToxicAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr);
      AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_ChanceToBecomeMutant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, nameof (ChanceToBecomeMutant));
      AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, nameof (IncreaseBloodQuality_Min));
      AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, nameof (IncreaseBloodQuality_Max));
      AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_MutantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, nameof (MutantType));
      AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_SpawnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, nameof (SpawnBuff));
      AffectPrisonerWithToxicAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, 100679958);
      AffectPrisonerWithToxicAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AffectPrisonerWithToxicAuthoring>.NativeClassPtr, 100679959);
    }

    public AffectPrisonerWithToxicAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ChanceToBecomeMutant
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_ChanceToBecomeMutant));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_ChanceToBecomeMutant)) = value;
      }
    }

    public unsafe float IncreaseBloodQuality_Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Min)) = value;
      }
    }

    public unsafe float IncreaseBloodQuality_Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_IncreaseBloodQuality_Max)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> MutantType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_MutantType));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_MutantType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> SpawnBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_SpawnBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AffectPrisonerWithToxicAuthoring.NativeFieldInfoPtr_SpawnBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
