// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GeneralGameplayCollectionAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class GeneralGameplayCollectionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_LKey_PerformanceInfoMessage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ServerIsRestartingMessage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ServerFailedSavingMessage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AFKWarningMessage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ServerQAMessage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ClientQAMessage;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 992649, RefRangeEnd = 992653, XrefRangeStart = 992649, XrefRangeEnd = 992653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(GeneralGameplayCollectionAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160641, XrefRangeEnd = 1160661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GeneralGameplayCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 992649, RefRangeEnd = 992653, XrefRangeStart = 992649, XrefRangeEnd = 992653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GeneralGameplayCollectionAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GeneralGameplayCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GeneralGameplayCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GeneralGameplayCollectionAsset()
    {
      Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (GeneralGameplayCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr);
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_PerformanceInfoMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_PerformanceInfoMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerIsRestartingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_ServerIsRestartingMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerFailedSavingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_ServerFailedSavingMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_AFKWarningMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_AFKWarningMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerQAMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_ServerQAMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ClientQAMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (LKey_ClientQAMessage));
      GeneralGameplayCollectionAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, nameof (_Guid));
      GeneralGameplayCollectionAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, 100692278);
      GeneralGameplayCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, 100692279);
      GeneralGameplayCollectionAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, 100692280);
      GeneralGameplayCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralGameplayCollectionAsset>.NativeClassPtr, 100692281);
    }

    public GeneralGameplayCollectionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LKey_PerformanceInfoMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_PerformanceInfoMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_PerformanceInfoMessage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerIsRestartingMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerIsRestartingMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerIsRestartingMessage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerFailedSavingMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerFailedSavingMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerFailedSavingMessage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AFKWarningMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_AFKWarningMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_AFKWarningMessage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServerQAMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerQAMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ServerQAMessage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ClientQAMessage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ClientQAMessage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr_LKey_ClientQAMessage)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralGameplayCollectionAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
