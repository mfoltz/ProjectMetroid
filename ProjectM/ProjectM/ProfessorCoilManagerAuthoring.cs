// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilManagerAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ProfessorCoilManagerAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TickRate;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoredBuffModifications;
    private static readonly IntPtr NativeFieldInfoPtr_HitBuff;
    private static readonly IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996249, XrefRangeEnd = 996263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilManagerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProfessorCoilManagerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilManagerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProfessorCoilManagerAuthoring()
    {
      Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProfessorCoilManagerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr);
      ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_TickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, nameof (TickRate));
      ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_IgnoredBuffModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, nameof (IgnoredBuffModifications));
      ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_HitBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, nameof (HitBuff));
      ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, nameof (DamageParameters));
      ProfessorCoilManagerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, 100676987);
      ProfessorCoilManagerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilManagerAuthoring>.NativeClassPtr, 100676988);
    }

    public ProfessorCoilManagerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TickRate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_TickRate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_TickRate)) = value;
      }
    }

    public unsafe long IgnoredBuffModifications
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_IgnoredBuffModifications));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_IgnoredBuffModifications)) = value;
      }
    }

    public unsafe WeakAssetReference<BuffComponent> HitBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_HitBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<BuffComponent>) null : new WeakAssetReference<BuffComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_HitBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public DealDamageParameters_Editor DamageParameters
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_DamageParameters);
        return new DealDamageParameters_Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilManagerAuthoring.NativeFieldInfoPtr_DamageParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
