// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.NewsData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class NewsData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ads;
    private static readonly System.IntPtr NativeFieldInfoPtr_News;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hash;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Hash_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe string Hash
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NewsData.NativeMethodInfoPtr_get_Hash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279354, RefRangeEnd = 1279355, XrefRangeStart = 1279314, XrefRangeEnd = 1279354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Process(string rawData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(rawData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsData.NativeMethodInfoPtr_Process_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NewsData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NewsData()
    {
      Il2CppClassPointerStore<NewsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (NewsData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsData>.NativeClassPtr);
      NewsData.NativeFieldInfoPtr_Ads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsData>.NativeClassPtr, nameof (Ads));
      NewsData.NativeFieldInfoPtr_News = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsData>.NativeClassPtr, nameof (News));
      NewsData.NativeFieldInfoPtr__Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsData>.NativeClassPtr, nameof (_Hash));
      NewsData.NativeMethodInfoPtr_get_Hash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsData>.NativeClassPtr, 100668918);
      NewsData.NativeMethodInfoPtr_Process_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsData>.NativeClassPtr, 100668919);
      NewsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsData>.NativeClassPtr, 100668920);
    }

    public NewsData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<NewsPanelEntryData> Ads
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr_Ads));
        return pointer == System.IntPtr.Zero ? (List<NewsPanelEntryData>) null : new List<NewsPanelEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr_Ads), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<NewsPanelEntryData> News
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr_News));
        return pointer == System.IntPtr.Zero ? (List<NewsPanelEntryData>) null : new List<NewsPanelEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr_News), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Hash
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr__Hash)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsData.NativeFieldInfoPtr__Hash), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
