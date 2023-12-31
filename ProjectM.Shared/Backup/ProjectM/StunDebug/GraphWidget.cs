// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.GraphWidget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class GraphWidget : DebugWidget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GraphData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DrawGraphType_LinearFloatCurve_Color_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMinAndMaxValue_Private_Void_byref_Single_byref_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawGraph_Private_Void_Rect_Single_Single_Single_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772018, RefRangeEnd = 772019, XrefRangeStart = 772014, XrefRangeEnd = 772018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphWidget(
      string name,
      GraphWidget.DrawGraphType drawType,
      LinearFloatCurve curvePtr,
      Color color,
      float timeLenght)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &drawType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curvePtr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &timeLenght;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphWidget.NativeMethodInfoPtr__ctor_Public_Void_String_DrawGraphType_LinearFloatCurve_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772019, XrefRangeEnd = 772060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Rect DrawOnScreen(Rect rect, float z)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GraphWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 772069, RefRangeEnd = 772071, XrefRangeStart = 772060, XrefRangeEnd = 772069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetMinAndMaxValue(
      out float min,
      out float max,
      float startTime,
      float endTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &endTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphWidget.NativeMethodInfoPtr_GetMinAndMaxValue_Private_Void_byref_Single_byref_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772123, RefRangeEnd = 772124, XrefRangeStart = 772071, XrefRangeEnd = 772123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawGraph(
      Rect rect,
      float z,
      float startTime,
      float endTime,
      bool drawBorder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &rect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &endTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &drawBorder;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphWidget.NativeMethodInfoPtr_DrawGraph_Private_Void_Rect_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphWidget()
    {
      Il2CppClassPointerStore<GraphWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (GraphWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr);
      GraphWidget.NativeFieldInfoPtr__GraphData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, nameof (_GraphData));
      GraphWidget.NativeMethodInfoPtr__ctor_Public_Void_String_DrawGraphType_LinearFloatCurve_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, 100668363);
      GraphWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, 100668364);
      GraphWidget.NativeMethodInfoPtr_GetMinAndMaxValue_Private_Void_byref_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, 100668365);
      GraphWidget.NativeMethodInfoPtr_DrawGraph_Private_Void_Rect_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, 100668366);
    }

    public GraphWidget(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GraphWidget.DrawGraphData _GraphData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.NativeFieldInfoPtr__GraphData);
        return new GraphWidget.DrawGraphData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.NativeFieldInfoPtr__GraphData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public enum DrawGraphType
    {
      KeyframeStack,
      LinearCurve,
      LinearCurveWithKeyframeStack,
    }

    public sealed class DrawGraphData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeLength;

      static DrawGraphData()
      {
        Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphWidget>.NativeClassPtr, nameof (DrawGraphData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr);
        GraphWidget.DrawGraphData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, nameof (Name));
        GraphWidget.DrawGraphData.NativeFieldInfoPtr_DrawType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, nameof (DrawType));
        GraphWidget.DrawGraphData.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, nameof (Curve));
        GraphWidget.DrawGraphData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, nameof (Color));
        GraphWidget.DrawGraphData.NativeFieldInfoPtr_TimeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, nameof (TimeLength));
      }

      public DrawGraphData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public DrawGraphData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphWidget.DrawGraphData>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe GraphWidget.DrawGraphType DrawType
      {
        get
        {
          return *(GraphWidget.DrawGraphType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_DrawType));
        }
        [param: In] set
        {
          *(GraphWidget.DrawGraphType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_DrawType)) = value;
        }
      }

      public unsafe LinearFloatCurve Curve
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Curve));
          return pointer == System.IntPtr.Zero ? (LinearFloatCurve) null : new LinearFloatCurve(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Color Color
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Color));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_Color)) = value;
        }
      }

      public unsafe float TimeLength
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_TimeLength));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphWidget.DrawGraphData.NativeFieldInfoPtr_TimeLength)) = value;
        }
      }
    }
  }
}
