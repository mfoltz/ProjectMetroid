// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.SRPBatcherProfiler
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Profiling;

#nullable disable
namespace UnityEngine.Experimental.Rendering
{
  public class SRPBatcherProfiler : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Enable;
    private static readonly System.IntPtr NativeFieldInfoPtr_kAverageStatDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_frameCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccDeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_statsLabel;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_style;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_oldBatcherEnable;
    private static readonly System.IntPtr NativeFieldInfoPtr_recordersList;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RazCounters_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetStats_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleStats_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925837, XrefRangeEnd = 925872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 925873, RefRangeEnd = 925879, XrefRangeStart = 925872, XrefRangeEnd = 925873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RazCounters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_RazCounters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925879, XrefRangeEnd = 925883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetStats()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_ResetStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925883, XrefRangeEnd = 925887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleStats()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_ToggleStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925887, XrefRangeEnd = 925983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925983, XrefRangeEnd = 926008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnGUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926008, XrefRangeEnd = 926141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SRPBatcherProfiler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SRPBatcherProfiler()
    {
      Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "UnityEngine.Experimental.Rendering", nameof (SRPBatcherProfiler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr);
      SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_Enable));
      SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (kAverageStatDuration));
      SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_frameCount));
      SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_AccDeltaTime));
      SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_statsLabel));
      SRPBatcherProfiler.NativeFieldInfoPtr_m_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_style));
      SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (m_oldBatcherEnable));
      SRPBatcherProfiler.NativeFieldInfoPtr_recordersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (recordersList));
      SRPBatcherProfiler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663975);
      SRPBatcherProfiler.NativeMethodInfoPtr_RazCounters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663976);
      SRPBatcherProfiler.NativeMethodInfoPtr_ResetStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663977);
      SRPBatcherProfiler.NativeMethodInfoPtr_ToggleStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663978);
      SRPBatcherProfiler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663979);
      SRPBatcherProfiler.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663980);
      SRPBatcherProfiler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100663981);
    }

    public SRPBatcherProfiler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool m_Enable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable)) = value;
      }
    }

    public static unsafe float kAverageStatDuration
    {
      get
      {
        float averageStatDuration;
        IL2CPP.il2cpp_field_static_get_value(SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration, (void*) &averageStatDuration);
        return averageStatDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration, (void*) &value);
      }
    }

    public unsafe int m_frameCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount)) = value;
      }
    }

    public unsafe float m_AccDeltaTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime)) = value;
      }
    }

    public unsafe string m_statsLabel
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GUIStyle m_style
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_style));
        return pointer == System.IntPtr.Zero ? (GUIStyle) null : new GUIStyle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_style), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool m_oldBatcherEnable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<SRPBatcherProfiler.RecorderEntry> recordersList
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_recordersList));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SRPBatcherProfiler.RecorderEntry>) null : new Il2CppReferenceArray<SRPBatcherProfiler.RecorderEntry>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_recordersList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class RecorderEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_name;
      private static readonly System.IntPtr NativeFieldInfoPtr_oldName;
      private static readonly System.IntPtr NativeFieldInfoPtr_callCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_accTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_recorder;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RecorderEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.RecorderEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecorderEntry()
      {
        Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, nameof (RecorderEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr);
        SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, nameof (name));
        SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, nameof (oldName));
        SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, nameof (callCount));
        SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, nameof (accTime));
        SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, nameof (recorder));
        SRPBatcherProfiler.RecorderEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, 100663982);
      }

      public RecorderEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string oldName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int callCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount)) = value;
        }
      }

      public unsafe float accTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime)) = value;
        }
      }

      public unsafe Recorder recorder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder));
          return pointer == System.IntPtr.Zero ? (Recorder) null : new Recorder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public enum SRPBMarkers
    {
      kStdRenderDraw,
      kStdShadowDraw,
      kSRPBRenderDraw,
      kSRPBShadowDraw,
      kRenderThreadIdle,
      kStdRenderApplyShader,
      kStdShadowApplyShader,
      kSRPBRenderApplyShader,
      kSRPBShadowApplyShader,
      kPrepareBatchRendererGroupNodes,
    }
  }
}
