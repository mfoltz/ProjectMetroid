// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods
{
  public sealed class ModsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopymodinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnumeratemodsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_InstallmodApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModIdentifierApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UninstallmodApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatemodApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyModInfo_Public_Result_byref_CopyModInfoOptions_byref_Nullable_1_ModInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateMods_Public_Void_byref_EnumerateModsOptions_Object_OnEnumerateModsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstallMod_Public_Void_byref_InstallModOptions_Object_OnInstallModCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UninstallMod_Public_Void_byref_UninstallModOptions_Object_OnUninstallModCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMod_Public_Void_byref_UpdateModOptions_Object_OnUpdateModCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_byref_EnumerateModsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_byref_InstallModCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_byref_UninstallModCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_byref_UpdateModCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952839, XrefRangeEnd = 952853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyModInfo(
      ref CopyModInfoOptions options,
      out Il2CppSystem.Nullable<ModInfo> outEnumeratedMods)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_CopyModInfo_Public_Result_byref_CopyModInfoOptions_byref_Nullable_1_ModInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ModInfo> local = ref outEnumeratedMods;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ModInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952853, XrefRangeEnd = 952872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnumerateMods(
      ref EnumerateModsOptions options,
      Il2CppSystem.Object clientData,
      OnEnumerateModsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_EnumerateMods_Public_Void_byref_EnumerateModsOptions_Object_OnEnumerateModsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952872, XrefRangeEnd = 952891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InstallMod(
      ref InstallModOptions options,
      Il2CppSystem.Object clientData,
      OnInstallModCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_InstallMod_Public_Void_byref_InstallModOptions_Object_OnInstallModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952891, XrefRangeEnd = 952910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UninstallMod(
      ref UninstallModOptions options,
      Il2CppSystem.Object clientData,
      OnUninstallModCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_UninstallMod_Public_Void_byref_UninstallModOptions_Object_OnUninstallModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952910, XrefRangeEnd = 952929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMod(
      ref UpdateModOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateModCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_UpdateMod_Public_Void_byref_UpdateModOptions_Object_OnUpdateModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952929, XrefRangeEnd = 952936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnEnumerateModsCallbackInternalImplementation(
      ref EnumerateModsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_byref_EnumerateModsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952936, XrefRangeEnd = 952943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnInstallModCallbackInternalImplementation(
      ref InstallModCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_byref_InstallModCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952943, XrefRangeEnd = 952950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUninstallModCallbackInternalImplementation(
      ref UninstallModCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_byref_UninstallModCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952950, XrefRangeEnd = 952957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateModCallbackInternalImplementation(
      ref UpdateModCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_byref_UpdateModCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModsInterface()
    {
      Il2CppClassPointerStore<ModsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Mods", nameof (ModsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr);
      ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (CopymodinfoApiLatest));
      ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (EnumeratemodsApiLatest));
      ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (InstallmodApiLatest));
      ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (ModIdentifierApiLatest));
      ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (ModinfoApiLatest));
      ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (UninstallmodApiLatest));
      ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (UpdatemodApiLatest));
      ModsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669383);
      ModsInterface.NativeMethodInfoPtr_CopyModInfo_Public_Result_byref_CopyModInfoOptions_byref_Nullable_1_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669385);
      ModsInterface.NativeMethodInfoPtr_EnumerateMods_Public_Void_byref_EnumerateModsOptions_Object_OnEnumerateModsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669386);
      ModsInterface.NativeMethodInfoPtr_InstallMod_Public_Void_byref_InstallModOptions_Object_OnInstallModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669387);
      ModsInterface.NativeMethodInfoPtr_UninstallMod_Public_Void_byref_UninstallModOptions_Object_OnUninstallModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669388);
      ModsInterface.NativeMethodInfoPtr_UpdateMod_Public_Void_byref_UpdateModOptions_Object_OnUpdateModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669389);
      ModsInterface.NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_byref_EnumerateModsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669390);
      ModsInterface.NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_byref_InstallModCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669391);
      ModsInterface.NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_byref_UninstallModCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669392);
      ModsInterface.NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_byref_UpdateModCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100669393);
    }

    public ModsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopymodinfoApiLatest
    {
      get
      {
        int copymodinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest, (void*) &copymodinfoApiLatest);
        return copymodinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int EnumeratemodsApiLatest
    {
      get
      {
        int enumeratemodsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest, (void*) &enumeratemodsApiLatest);
        return enumeratemodsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest, (void*) &value);
      }
    }

    public static unsafe int InstallmodApiLatest
    {
      get
      {
        int installmodApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest, (void*) &installmodApiLatest);
        return installmodApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest, (void*) &value);
      }
    }

    public static unsafe int ModIdentifierApiLatest
    {
      get
      {
        int identifierApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest, (void*) &identifierApiLatest);
        return identifierApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest, (void*) &value);
      }
    }

    public static unsafe int ModinfoApiLatest
    {
      get
      {
        int modinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest, (void*) &modinfoApiLatest);
        return modinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int UninstallmodApiLatest
    {
      get
      {
        int uninstallmodApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest, (void*) &uninstallmodApiLatest);
        return uninstallmodApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatemodApiLatest
    {
      get
      {
        int updatemodApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest, (void*) &updatemodApiLatest);
        return updatemodApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest, (void*) &value);
      }
    }
  }
}
