// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupConsumeItemOnCastComponent
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
  public class AbilityGroupConsumeItemOnCastComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreConsumeOnCast;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995869, XrefRangeEnd = 995872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupConsumeItemOnCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityGroupConsumeItemOnCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupConsumeItemOnCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityGroupConsumeItemOnCastComponent()
    {
      Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityGroupConsumeItemOnCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr);
      AbilityGroupConsumeItemOnCastComponent.NativeFieldInfoPtr_IgnoreConsumeOnCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr, nameof (IgnoreConsumeOnCast));
      AbilityGroupConsumeItemOnCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr, 100676901);
      AbilityGroupConsumeItemOnCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupConsumeItemOnCastComponent>.NativeClassPtr, 100676902);
    }

    public AbilityGroupConsumeItemOnCastComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnoreConsumeOnCast
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupConsumeItemOnCastComponent.NativeFieldInfoPtr_IgnoreConsumeOnCast));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupConsumeItemOnCastComponent.NativeFieldInfoPtr_IgnoreConsumeOnCast)) = value;
      }
    }
  }
}
