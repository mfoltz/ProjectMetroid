// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.ReplayUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Replays
{
  public class ReplayUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EXTENSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_REPLAY_FILES_REGEX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NUM_OF_REPLAYS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_REPLAY_LENGTH_SEC;
    private static readonly System.IntPtr NativeFieldInfoPtr_HEADER_BUFFER_MAX_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NUM_OF_EVENTS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NUM_OF_INPUT_EVENTS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NUM_OF_SNAPSHOTS;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveFolder_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetReplayFilesInSaveFolder_Public_Static_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1109576, RefRangeEnd = 1109580, XrefRangeStart = 1109569, XrefRangeEnd = 1109576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSaveFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ReplayUtilities.NativeMethodInfoPtr_GetSaveFolder_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109580, XrefRangeEnd = 1109594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStringArray GetReplayFilesInSaveFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayUtilities.NativeMethodInfoPtr_GetReplayFilesInSaveFolder_Public_Static_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplayUtilities()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplayUtilities()
    {
      Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Replays", nameof (ReplayUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr);
      ReplayUtilities.NativeFieldInfoPtr_EXTENSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (EXTENSION));
      ReplayUtilities.NativeFieldInfoPtr_REPLAY_FILES_REGEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (REPLAY_FILES_REGEX));
      ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_REPLAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (MAX_NUM_OF_REPLAYS));
      ReplayUtilities.NativeFieldInfoPtr_MAX_REPLAY_LENGTH_SEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (MAX_REPLAY_LENGTH_SEC));
      ReplayUtilities.NativeFieldInfoPtr_HEADER_BUFFER_MAX_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (HEADER_BUFFER_MAX_SIZE));
      ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_EVENTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (MAX_NUM_OF_EVENTS));
      ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_INPUT_EVENTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (MAX_NUM_OF_INPUT_EVENTS));
      ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_SNAPSHOTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, nameof (MAX_NUM_OF_SNAPSHOTS));
      ReplayUtilities.NativeMethodInfoPtr_GetSaveFolder_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, 100687833);
      ReplayUtilities.NativeMethodInfoPtr_GetReplayFilesInSaveFolder_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, 100687834);
      ReplayUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayUtilities>.NativeClassPtr, 100687835);
    }

    public ReplayUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string EXTENSION
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_EXTENSION, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_EXTENSION, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string REPLAY_FILES_REGEX
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_REPLAY_FILES_REGEX, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_REPLAY_FILES_REGEX, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int MAX_NUM_OF_REPLAYS
    {
      get
      {
        int maxNumOfReplays;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_REPLAYS, (void*) &maxNumOfReplays);
        return maxNumOfReplays;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_REPLAYS, (void*) &value);
      }
    }

    public static unsafe int MAX_REPLAY_LENGTH_SEC
    {
      get
      {
        int maxReplayLengthSec;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_MAX_REPLAY_LENGTH_SEC, (void*) &maxReplayLengthSec);
        return maxReplayLengthSec;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_MAX_REPLAY_LENGTH_SEC, (void*) &value);
      }
    }

    public static unsafe int HEADER_BUFFER_MAX_SIZE
    {
      get
      {
        int headerBufferMaxSize;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_HEADER_BUFFER_MAX_SIZE, (void*) &headerBufferMaxSize);
        return headerBufferMaxSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_HEADER_BUFFER_MAX_SIZE, (void*) &value);
      }
    }

    public static unsafe int MAX_NUM_OF_EVENTS
    {
      get
      {
        int maxNumOfEvents;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_EVENTS, (void*) &maxNumOfEvents);
        return maxNumOfEvents;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_EVENTS, (void*) &value);
      }
    }

    public static unsafe int MAX_NUM_OF_INPUT_EVENTS
    {
      get
      {
        int numOfInputEvents;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_INPUT_EVENTS, (void*) &numOfInputEvents);
        return numOfInputEvents;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_INPUT_EVENTS, (void*) &value);
      }
    }

    public static unsafe int MAX_NUM_OF_SNAPSHOTS
    {
      get
      {
        int maxNumOfSnapshots;
        IL2CPP.il2cpp_field_static_get_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_SNAPSHOTS, (void*) &maxNumOfSnapshots);
        return maxNumOfSnapshots;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayUtilities.NativeFieldInfoPtr_MAX_NUM_OF_SNAPSHOTS, (void*) &value);
      }
    }
  }
}
