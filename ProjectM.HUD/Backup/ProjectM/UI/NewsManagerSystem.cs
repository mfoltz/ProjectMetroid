// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.NewsManagerSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine.Networking;

#nullable disable
namespace ProjectM.UI
{
  public class NewsManagerSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DOWNLOAD_INTERVAL_NORMAL;
    private static readonly IntPtr NativeFieldInfoPtr_DOWNLOAD_INTERVAL_ERROR;
    private static readonly IntPtr NativeFieldInfoPtr_RETRY_INTERVAL;
    private static readonly IntPtr NativeFieldInfoPtr__SourceURL;
    private static readonly IntPtr NativeFieldInfoPtr__AdsProgressionEnabled;
    private static readonly IntPtr NativeFieldInfoPtr__NewsProgressionEnabled;
    private static readonly IntPtr NativeFieldInfoPtr__NextDownloadTime;
    private static readonly IntPtr NativeFieldInfoPtr__NewsDataTimestamp;
    private static readonly IntPtr NativeFieldInfoPtr__WebRequest;
    private static readonly IntPtr NativeFieldInfoPtr__NewsData;
    private static readonly IntPtr NativeFieldInfoPtr__ErrorCounter;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentAdsIndex;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentNewsIndex;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentAdsProgress;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentNewsProgress;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentView;
    private static readonly IntPtr NativeMethodInfoPtr_get_DownloadInProgress_Private_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AdsCount_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NewsCount_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAdsIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentNewsIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AdsProgress_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NewsProgress_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NewsData_Public_get_NewsData_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NewsDataTimestamp_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAdsProgression_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetNewsProgression_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetNextDownload_Private_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayProgress_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SwitchAds_Public_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SwitchNews_Public_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_mod_Private_Int32_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateDownloader_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetDataTimestamp_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetIndexes_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_getTimeNow_Private_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClearWebRequest_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool DownloadInProgress
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_DownloadInProgress_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int AdsCount
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 1279364, RefRangeEnd = 1279368, XrefRangeStart = 1279359, XrefRangeEnd = 1279364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_AdsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int NewsCount
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1279373, RefRangeEnd = 1279375, XrefRangeStart = 1279368, XrefRangeEnd = 1279373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_NewsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int CurrentAdsIndex
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 40943, RefRangeEnd = 40949, XrefRangeStart = 40943, XrefRangeEnd = 40949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_CurrentAdsIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int CurrentNewsIndex
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 43842, RefRangeEnd = 43846, XrefRangeStart = 43842, XrefRangeEnd = 43846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_CurrentNewsIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float AdsProgress
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279375, XrefRangeEnd = 1279379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_AdsProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float NewsProgress
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279379, XrefRangeEnd = 1279383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_NewsProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NewsData NewsData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_NewsData_Public_get_NewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (NewsData) null : new NewsData(pointer);
      }
    }

    public unsafe float NewsDataTimestamp
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_get_NewsDataTimestamp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279383, XrefRangeEnd = 1279385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NewsManagerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetAdsProgression(bool progress)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &progress;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_SetAdsProgression_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetNewsProgression(bool progress)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &progress;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_SetNewsProgression_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279385, XrefRangeEnd = 1279386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetNextDownload(float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &t;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_SetNextDownload_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279386, XrefRangeEnd = 1279389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NewsManagerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279402, RefRangeEnd = 1279403, XrefRangeStart = 1279389, XrefRangeEnd = 1279402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateDisplayProgress()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_UpdateDisplayProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1279404, RefRangeEnd = 1279406, XrefRangeStart = 1279403, XrefRangeEnd = 1279404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwitchAds(int change)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &change;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_SwitchAds_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1279407, RefRangeEnd = 1279409, XrefRangeStart = 1279406, XrefRangeEnd = 1279407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwitchNews(int change)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &change;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_SwitchNews_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int mod(int x, int m)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &x;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &m;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_mod_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279444, RefRangeEnd = 1279445, XrefRangeStart = 1279409, XrefRangeEnd = 1279444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateDownloader()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_UpdateDownloader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279445, XrefRangeEnd = 1279446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetDataTimestamp()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_ResetDataTimestamp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void ResetIndexes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_ResetIndexes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279446, XrefRangeEnd = 1279447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float getTimeNow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_getTimeNow_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279450, RefRangeEnd = 1279451, XrefRangeStart = 1279447, XrefRangeEnd = 1279450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearWebRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279451, XrefRangeEnd = 1279452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NewsManagerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsManagerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NewsManagerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NewsManagerSystem()
    {
      Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (NewsManagerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr);
      NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (DOWNLOAD_INTERVAL_NORMAL));
      NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (DOWNLOAD_INTERVAL_ERROR));
      NewsManagerSystem.NativeFieldInfoPtr_RETRY_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (RETRY_INTERVAL));
      NewsManagerSystem.NativeFieldInfoPtr__SourceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_SourceURL));
      NewsManagerSystem.NativeFieldInfoPtr__AdsProgressionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_AdsProgressionEnabled));
      NewsManagerSystem.NativeFieldInfoPtr__NewsProgressionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_NewsProgressionEnabled));
      NewsManagerSystem.NativeFieldInfoPtr__NextDownloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_NextDownloadTime));
      NewsManagerSystem.NativeFieldInfoPtr__NewsDataTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_NewsDataTimestamp));
      NewsManagerSystem.NativeFieldInfoPtr__WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_WebRequest));
      NewsManagerSystem.NativeFieldInfoPtr__NewsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_NewsData));
      NewsManagerSystem.NativeFieldInfoPtr__ErrorCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_ErrorCounter));
      NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_CurrentAdsIndex));
      NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_CurrentNewsIndex));
      NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_CurrentAdsProgress));
      NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_CurrentNewsProgress));
      NewsManagerSystem.NativeFieldInfoPtr__CurrentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, nameof (_CurrentView));
      NewsManagerSystem.NativeMethodInfoPtr_get_DownloadInProgress_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668925);
      NewsManagerSystem.NativeMethodInfoPtr_get_HasData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668926);
      NewsManagerSystem.NativeMethodInfoPtr_get_AdsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668927);
      NewsManagerSystem.NativeMethodInfoPtr_get_NewsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668928);
      NewsManagerSystem.NativeMethodInfoPtr_get_CurrentAdsIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668929);
      NewsManagerSystem.NativeMethodInfoPtr_get_CurrentNewsIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668930);
      NewsManagerSystem.NativeMethodInfoPtr_get_AdsProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668931);
      NewsManagerSystem.NativeMethodInfoPtr_get_NewsProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668932);
      NewsManagerSystem.NativeMethodInfoPtr_get_NewsData_Public_get_NewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668933);
      NewsManagerSystem.NativeMethodInfoPtr_get_NewsDataTimestamp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668934);
      NewsManagerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668935);
      NewsManagerSystem.NativeMethodInfoPtr_SetAdsProgression_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668936);
      NewsManagerSystem.NativeMethodInfoPtr_SetNewsProgression_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668937);
      NewsManagerSystem.NativeMethodInfoPtr_SetNextDownload_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668938);
      NewsManagerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668939);
      NewsManagerSystem.NativeMethodInfoPtr_UpdateDisplayProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668940);
      NewsManagerSystem.NativeMethodInfoPtr_SwitchAds_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668941);
      NewsManagerSystem.NativeMethodInfoPtr_SwitchNews_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668942);
      NewsManagerSystem.NativeMethodInfoPtr_mod_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668943);
      NewsManagerSystem.NativeMethodInfoPtr_UpdateDownloader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668944);
      NewsManagerSystem.NativeMethodInfoPtr_ResetDataTimestamp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668945);
      NewsManagerSystem.NativeMethodInfoPtr_ResetIndexes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668946);
      NewsManagerSystem.NativeMethodInfoPtr_getTimeNow_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668947);
      NewsManagerSystem.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668948);
      NewsManagerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668949);
      NewsManagerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsManagerSystem>.NativeClassPtr, 100668950);
    }

    public NewsManagerSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DOWNLOAD_INTERVAL_NORMAL
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_NORMAL));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_NORMAL)) = value;
      }
    }

    public unsafe float DOWNLOAD_INTERVAL_ERROR
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_ERROR));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_DOWNLOAD_INTERVAL_ERROR)) = value;
      }
    }

    public unsafe float RETRY_INTERVAL
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_RETRY_INTERVAL));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr_RETRY_INTERVAL)) = value;
      }
    }

    public unsafe string _SourceURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__SourceURL)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__SourceURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _AdsProgressionEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__AdsProgressionEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__AdsProgressionEnabled)) = value;
      }
    }

    public unsafe bool _NewsProgressionEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsProgressionEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsProgressionEnabled)) = value;
      }
    }

    public unsafe float _NextDownloadTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NextDownloadTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NextDownloadTime)) = value;
      }
    }

    public unsafe float _NewsDataTimestamp
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsDataTimestamp));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsDataTimestamp)) = value;
      }
    }

    public unsafe UnityWebRequest _WebRequest
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__WebRequest));
        return pointer == IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__WebRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewsData _NewsData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsData));
        return pointer == IntPtr.Zero ? (NewsData) null : new NewsData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__NewsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _ErrorCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__ErrorCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__ErrorCounter)) = value;
      }
    }

    public unsafe int _CurrentAdsIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsIndex)) = value;
      }
    }

    public unsafe int _CurrentNewsIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsIndex)) = value;
      }
    }

    public unsafe float _CurrentAdsProgress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsProgress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentAdsProgress)) = value;
      }
    }

    public unsafe float _CurrentNewsProgress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsProgress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentNewsProgress)) = value;
      }
    }

    public unsafe ViewLocation _CurrentView
    {
      get
      {
        return *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentView));
      }
      [param: In] set
      {
        *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsManagerSystem.NativeFieldInfoPtr__CurrentView)) = value;
      }
    }
  }
}
