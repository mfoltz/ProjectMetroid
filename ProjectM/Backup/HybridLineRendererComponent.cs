// Decompiled with JetBrains decompiler
// Type: HybridLineRendererComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public class HybridLineRendererComponent : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__LineRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_Positions;
  private static readonly IntPtr NativeFieldInfoPtr_ThrowCurve;
  private static readonly IntPtr NativeFieldInfoPtr_ThrowCurveNodes;
  private static readonly IntPtr NativeMethodInfoPtr_get_LineRenderer_Public_get_LineRenderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LineRenderer_Public_set_Void_LineRenderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateThrowArc_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateStandard_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_float3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe LineRenderer LineRenderer
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_get_LineRenderer_Public_get_LineRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LineRenderer) null : new LineRenderer(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_set_LineRenderer_Public_set_Void_LineRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915328, XrefRangeEnd = 915332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915351, RefRangeEnd = 915352, XrefRangeStart = 915332, XrefRangeEnd = 915351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateThrowArc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_CalculateThrowArc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915352, XrefRangeEnd = 915359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CalculateStandard()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_CalculateStandard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915359, XrefRangeEnd = 915363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915367, RefRangeEnd = 915368, XrefRangeStart = 915363, XrefRangeEnd = 915367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(int positionIndex, float3 float3Value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positionIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &float3Value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915380, RefRangeEnd = 915381, XrefRangeStart = 915368, XrefRangeEnd = 915380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915381, XrefRangeEnd = 915389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridLineRendererComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRendererComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridLineRendererComponent()
  {
    Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridLineRendererComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr);
    HybridLineRendererComponent.NativeFieldInfoPtr__LineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, nameof (_LineRenderer));
    HybridLineRendererComponent.NativeFieldInfoPtr_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, nameof (Positions));
    HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, nameof (ThrowCurve));
    HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurveNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, nameof (ThrowCurveNodes));
    HybridLineRendererComponent.NativeMethodInfoPtr_get_LineRenderer_Public_get_LineRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663571);
    HybridLineRendererComponent.NativeMethodInfoPtr_set_LineRenderer_Public_set_Void_LineRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663572);
    HybridLineRendererComponent.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663573);
    HybridLineRendererComponent.NativeMethodInfoPtr_CalculateThrowArc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663574);
    HybridLineRendererComponent.NativeMethodInfoPtr_CalculateStandard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663575);
    HybridLineRendererComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663576);
    HybridLineRendererComponent.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663577);
    HybridLineRendererComponent.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663578);
    HybridLineRendererComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRendererComponent>.NativeClassPtr, 100663579);
  }

  public HybridLineRendererComponent(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LineRenderer _LineRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr__LineRenderer));
      return pointer == IntPtr.Zero ? (LineRenderer) null : new LineRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr__LineRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Vector3> Positions
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_Positions));
      return pointer == IntPtr.Zero ? (List<Vector3>) null : new List<Vector3>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_Positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ThrowCurve
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurve));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurve)) = value;
    }
  }

  public unsafe int ThrowCurveNodes
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurveNodes));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRendererComponent.NativeFieldInfoPtr_ThrowCurveNodes)) = value;
    }
  }
}
