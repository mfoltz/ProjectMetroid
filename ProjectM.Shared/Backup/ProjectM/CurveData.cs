// Decompiled with JetBrains decompiler
// Type: ProjectM.CurveData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CurveData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_KEY_FRAME_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyFrameCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyFrames_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyFrames_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyFrames_InTangent;
    private static readonly System.IntPtr NativeFieldInfoPtr_keyFrames_OutTangent;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SEGMENTS_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_segments_a;
    private static readonly System.IntPtr NativeFieldInfoPtr_segments_b;
    private static readonly System.IntPtr NativeFieldInfoPtr_segments_c;
    private static readonly System.IntPtr NativeFieldInfoPtr_segments_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_preWrapMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_postWrapMode;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateSegment_Private_Single_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToAnimationCurve_Public_AnimationCurve_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromAnimationCurve_Public_Static_CurveData_AnimationCurve_0;
    [FieldOffset(0)]
    public int keyFrameCount;
    [FieldOffset(4)]
    public CurveData._keyFrames_Time_e__FixedBuffer keyFrames_Time;
    [FieldOffset(132)]
    public CurveData._keyFrames_Value_e__FixedBuffer keyFrames_Value;
    [FieldOffset(260)]
    public CurveData._keyFrames_InTangent_e__FixedBuffer keyFrames_InTangent;
    [FieldOffset(388)]
    public CurveData._keyFrames_OutTangent_e__FixedBuffer keyFrames_OutTangent;
    [FieldOffset(516)]
    public CurveData._segments_a_e__FixedBuffer segments_a;
    [FieldOffset(640)]
    public CurveData._segments_b_e__FixedBuffer segments_b;
    [FieldOffset(764)]
    public CurveData._segments_c_e__FixedBuffer segments_c;
    [FieldOffset(888)]
    public CurveData._segments_d_e__FixedBuffer segments_d;
    [FieldOffset(1012)]
    public WrapMode preWrapMode;
    [FieldOffset(1016)]
    public WrapMode postWrapMode;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726556, RefRangeEnd = 726557, XrefRangeStart = 726554, XrefRangeEnd = 726556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float EvaluateSegment(int index, float t)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveData.NativeMethodInfoPtr_EvaluateSegment_Private_Single_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726562, RefRangeEnd = 726563, XrefRangeStart = 726557, XrefRangeEnd = 726562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(float t, float duration, bool clamp = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clamp;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 726568, RefRangeEnd = 726591, XrefRangeStart = 726563, XrefRangeEnd = 726568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(float t)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &t;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726591, XrefRangeEnd = 726607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationCurve ToAnimationCurve(bool flipY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flipY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveData.NativeMethodInfoPtr_ToAnimationCurve_Public_AnimationCurve_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726642, RefRangeEnd = 726643, XrefRangeStart = 726607, XrefRangeEnd = 726642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CurveData FromAnimationCurve(AnimationCurve animationCurve)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationCurve);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveData.NativeMethodInfoPtr_FromAnimationCurve_Public_Static_CurveData_AnimationCurve_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CurveData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CurveData()
    {
      Il2CppClassPointerStore<CurveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CurveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData>.NativeClassPtr);
      CurveData.NativeFieldInfoPtr_MAX_KEY_FRAME_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (MAX_KEY_FRAME_COUNT));
      CurveData.NativeFieldInfoPtr_keyFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (keyFrameCount));
      CurveData.NativeFieldInfoPtr_keyFrames_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (keyFrames_Time));
      CurveData.NativeFieldInfoPtr_keyFrames_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (keyFrames_Value));
      CurveData.NativeFieldInfoPtr_keyFrames_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (keyFrames_InTangent));
      CurveData.NativeFieldInfoPtr_keyFrames_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (keyFrames_OutTangent));
      CurveData.NativeFieldInfoPtr_MAX_SEGMENTS_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (MAX_SEGMENTS_COUNT));
      CurveData.NativeFieldInfoPtr_segments_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (segments_a));
      CurveData.NativeFieldInfoPtr_segments_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (segments_b));
      CurveData.NativeFieldInfoPtr_segments_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (segments_c));
      CurveData.NativeFieldInfoPtr_segments_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (segments_d));
      CurveData.NativeFieldInfoPtr_preWrapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (preWrapMode));
      CurveData.NativeFieldInfoPtr_postWrapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData>.NativeClassPtr, nameof (postWrapMode));
      CurveData.NativeMethodInfoPtr_EvaluateSegment_Private_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveData>.NativeClassPtr, 100664222);
      CurveData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveData>.NativeClassPtr, 100664223);
      CurveData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveData>.NativeClassPtr, 100664224);
      CurveData.NativeMethodInfoPtr_ToAnimationCurve_Public_AnimationCurve_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveData>.NativeClassPtr, 100664225);
      CurveData.NativeMethodInfoPtr_FromAnimationCurve_Public_Static_CurveData_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveData>.NativeClassPtr, 100664226);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_KEY_FRAME_COUNT
    {
      get
      {
        int maxKeyFrameCount;
        IL2CPP.il2cpp_field_static_get_value(CurveData.NativeFieldInfoPtr_MAX_KEY_FRAME_COUNT, (void*) &maxKeyFrameCount);
        return maxKeyFrameCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CurveData.NativeFieldInfoPtr_MAX_KEY_FRAME_COUNT, (void*) &value);
      }
    }

    public static unsafe int MAX_SEGMENTS_COUNT
    {
      get
      {
        int maxSegmentsCount;
        IL2CPP.il2cpp_field_static_get_value(CurveData.NativeFieldInfoPtr_MAX_SEGMENTS_COUNT, (void*) &maxSegmentsCount);
        return maxSegmentsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CurveData.NativeFieldInfoPtr_MAX_SEGMENTS_COUNT, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<keyFrames_Time>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _keyFrames_Time_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _keyFrames_Time_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._keyFrames_Time_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<keyFrames_Time>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._keyFrames_Time_e__FixedBuffer>.NativeClassPtr);
        CurveData._keyFrames_Time_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._keyFrames_Time_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._keyFrames_Time_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<keyFrames_Value>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _keyFrames_Value_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _keyFrames_Value_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._keyFrames_Value_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<keyFrames_Value>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._keyFrames_Value_e__FixedBuffer>.NativeClassPtr);
        CurveData._keyFrames_Value_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._keyFrames_Value_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._keyFrames_Value_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<keyFrames_InTangent>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _keyFrames_InTangent_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _keyFrames_InTangent_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._keyFrames_InTangent_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<keyFrames_InTangent>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._keyFrames_InTangent_e__FixedBuffer>.NativeClassPtr);
        CurveData._keyFrames_InTangent_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._keyFrames_InTangent_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._keyFrames_InTangent_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<keyFrames_OutTangent>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _keyFrames_OutTangent_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _keyFrames_OutTangent_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._keyFrames_OutTangent_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<keyFrames_OutTangent>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._keyFrames_OutTangent_e__FixedBuffer>.NativeClassPtr);
        CurveData._keyFrames_OutTangent_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._keyFrames_OutTangent_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._keyFrames_OutTangent_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<segments_a>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _segments_a_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _segments_a_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._segments_a_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<segments_a>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._segments_a_e__FixedBuffer>.NativeClassPtr);
        CurveData._segments_a_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._segments_a_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._segments_a_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<segments_b>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _segments_b_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _segments_b_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._segments_b_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<segments_b>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._segments_b_e__FixedBuffer>.NativeClassPtr);
        CurveData._segments_b_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._segments_b_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._segments_b_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<segments_c>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _segments_c_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _segments_c_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._segments_c_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<segments_c>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._segments_c_e__FixedBuffer>.NativeClassPtr);
        CurveData._segments_c_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._segments_c_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._segments_c_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveData/<segments_d>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _segments_d_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _segments_d_e__FixedBuffer()
      {
        Il2CppClassPointerStore<CurveData._segments_d_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveData>.NativeClassPtr, "<segments_d>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveData._segments_d_e__FixedBuffer>.NativeClassPtr);
        CurveData._segments_d_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveData._segments_d_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveData._segments_d_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
