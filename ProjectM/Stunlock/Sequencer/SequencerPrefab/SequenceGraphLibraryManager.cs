// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.SequenceGraphLibraryManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  public static class SequenceGraphLibraryManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SequenceGraphLibraryAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstGraphDataWithTag_Public_Static_SequenceGraphData_SequenceGraphLibraryTag_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 925501, RefRangeEnd = 925502, XrefRangeStart = 925472, XrefRangeEnd = 925501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SequenceGraphData GetFirstGraphDataWithTag(SequenceGraphLibraryTag tag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphLibraryManager.NativeMethodInfoPtr_GetFirstGraphDataWithTag_Public_Static_SequenceGraphData_SequenceGraphLibraryTag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceGraphData) null : new SequenceGraphData(pointer);
    }

    static SequenceGraphLibraryManager()
    {
      Il2CppClassPointerStore<SequenceGraphLibraryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (SequenceGraphLibraryManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphLibraryManager>.NativeClassPtr);
      SequenceGraphLibraryManager.NativeFieldInfoPtr__SequenceGraphLibraryAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphLibraryManager>.NativeClassPtr, nameof (_SequenceGraphLibraryAsset));
      SequenceGraphLibraryManager.NativeMethodInfoPtr_GetFirstGraphDataWithTag_Public_Static_SequenceGraphData_SequenceGraphLibraryTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphLibraryManager>.NativeClassPtr, 100663967);
    }

    public SequenceGraphLibraryManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SequencerSettingsProviderAsset _SequenceGraphLibraryAsset
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SequenceGraphLibraryManager.NativeFieldInfoPtr__SequenceGraphLibraryAsset, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequencerSettingsProviderAsset) null : new SequencerSettingsProviderAsset(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SequenceGraphLibraryManager.NativeFieldInfoPtr__SequenceGraphLibraryAsset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
