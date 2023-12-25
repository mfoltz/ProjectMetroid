// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequencerSettingsProviderAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequencerSettingsProviderAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsAssetName;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsPath;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequenceGraphLibrary;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SequenceGraphLibrary_Public_get_List_1_SequenceGraphTagData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe List<SequencerSettingsProviderAsset.SequenceGraphTagData> SequenceGraphLibrary
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerSettingsProviderAsset.NativeMethodInfoPtr_get_SequenceGraphLibrary_Public_get_List_1_SequenceGraphTagData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<SequencerSettingsProviderAsset.SequenceGraphTagData>) null : new List<SequencerSettingsProviderAsset.SequenceGraphTagData>(pointer);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequencerSettingsProviderAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerSettingsProviderAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequencerSettingsProviderAsset()
    {
      Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequencerSettingsProviderAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr);
      SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, nameof (SettingsAssetName));
      SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, nameof (SettingsPath));
      SequencerSettingsProviderAsset.NativeFieldInfoPtr__SequenceGraphLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, nameof (_SequenceGraphLibrary));
      SequencerSettingsProviderAsset.NativeMethodInfoPtr_get_SequenceGraphLibrary_Public_get_List_1_SequenceGraphTagData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, 100687246);
      SequencerSettingsProviderAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, 100687247);
    }

    public SequencerSettingsProviderAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string SettingsAssetName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsAssetName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsAssetName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SettingsPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SequencerSettingsProviderAsset.NativeFieldInfoPtr_SettingsPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<SequencerSettingsProviderAsset.SequenceGraphTagData> _SequenceGraphLibrary
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.NativeFieldInfoPtr__SequenceGraphLibrary));
        return pointer == System.IntPtr.Zero ? (List<SequencerSettingsProviderAsset.SequenceGraphTagData>) null : new List<SequencerSettingsProviderAsset.SequenceGraphTagData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.NativeFieldInfoPtr__SequenceGraphLibrary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class SequenceGraphTagData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GraphData;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tag;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SequenceGraphTagData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequencerSettingsProviderAsset.SequenceGraphTagData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SequenceGraphTagData()
      {
        Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequencerSettingsProviderAsset>.NativeClassPtr, nameof (SequenceGraphTagData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr);
        SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_GraphData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr, nameof (GraphData));
        SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr, nameof (Tag));
        SequencerSettingsProviderAsset.SequenceGraphTagData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerSettingsProviderAsset.SequenceGraphTagData>.NativeClassPtr, 100687248);
      }

      public SequenceGraphTagData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SequenceGraphData GraphData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_GraphData));
          return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_GraphData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SequenceGraphLibraryTag Tag
      {
        get
        {
          return *(SequenceGraphLibraryTag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_Tag));
        }
        [param: In] set
        {
          *(SequenceGraphLibraryTag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerSettingsProviderAsset.SequenceGraphTagData.NativeFieldInfoPtr_Tag)) = value;
        }
      }
    }
  }
}
