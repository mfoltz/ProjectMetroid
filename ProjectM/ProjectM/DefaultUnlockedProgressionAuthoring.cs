// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultUnlockedProgressionAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DefaultUnlockedProgressionAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultUnlockedProgressionAbilities;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultUnlockedProgressionShapeshifts;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028955, XrefRangeEnd = 1028978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DefaultUnlockedProgressionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultUnlockedProgressionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultUnlockedProgressionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DefaultUnlockedProgressionAuthoring()
    {
      Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DefaultUnlockedProgressionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr);
      DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr, nameof (DefaultUnlockedProgressionAbilities));
      DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionShapeshifts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr, nameof (DefaultUnlockedProgressionShapeshifts));
      DefaultUnlockedProgressionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr, 100680333);
      DefaultUnlockedProgressionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultUnlockedProgressionAuthoring>.NativeClassPtr, 100680334);
    }

    public DefaultUnlockedProgressionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<WeakAssetReference<AbilityGroupComponent>> DefaultUnlockedProgressionAbilities
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionAbilities));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<AbilityGroupComponent>>) null : new List<WeakAssetReference<AbilityGroupComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionAbilities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<AbilityGroupComponent>> DefaultUnlockedProgressionShapeshifts
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionShapeshifts));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<AbilityGroupComponent>>) null : new List<WeakAssetReference<AbilityGroupComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultUnlockedProgressionAuthoring.NativeFieldInfoPtr_DefaultUnlockedProgressionShapeshifts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
