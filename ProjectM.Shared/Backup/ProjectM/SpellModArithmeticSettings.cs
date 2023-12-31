// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModArithmeticSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class SpellModArithmeticSettings : SpellModSettings
  {
    private static readonly IntPtr NativeFieldInfoPtr_Operation;
    private static readonly IntPtr NativeFieldInfoPtr_ValueIndex;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticTarget_Int32_MonoBehaviour_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticModifiableTarget_Int32_MonoBehaviour_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 728587, RefRangeEnd = 728644, XrefRangeStart = 728569, XrefRangeEnd = 728587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      SpellModArithmeticTarget target,
      int targetIndex,
      MonoBehaviour builderComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &targetIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builderComponent);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticTarget_Int32_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 728662, RefRangeEnd = 728666, XrefRangeStart = 728644, XrefRangeEnd = 728662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      SpellModArithmeticModifiableTarget target,
      int targetIndex,
      MonoBehaviour builderComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &targetIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builderComponent);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticModifiableTarget_Int32_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModArithmeticSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModArithmeticSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModArithmeticSettings()
    {
      Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellModArithmeticSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr);
      SpellModArithmeticSettings.NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr, nameof (Operation));
      SpellModArithmeticSettings.NativeFieldInfoPtr_ValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr, nameof (ValueIndex));
      SpellModArithmeticSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticTarget_Int32_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr, 100664520);
      SpellModArithmeticSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModArithmeticModifiableTarget_Int32_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr, 100664521);
      SpellModArithmeticSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModArithmeticSettings>.NativeClassPtr, 100664522);
    }

    public SpellModArithmeticSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpellModArithmeticOperation Operation
    {
      get
      {
        return *(SpellModArithmeticOperation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModArithmeticSettings.NativeFieldInfoPtr_Operation));
      }
      [param: In] set
      {
        *(SpellModArithmeticOperation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModArithmeticSettings.NativeFieldInfoPtr_Operation)) = value;
      }
    }

    public unsafe byte ValueIndex
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModArithmeticSettings.NativeFieldInfoPtr_ValueIndex));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModArithmeticSettings.NativeFieldInfoPtr_ValueIndex)) = value;
      }
    }
  }
}
