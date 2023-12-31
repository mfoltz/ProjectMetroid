// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.PositionCurveWidget
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
namespace ProjectM.StunDebug
{
  public class PositionCurveWidget : DebugWidget
  {
    private static readonly IntPtr NativeFieldInfoPtr__Color;
    private static readonly IntPtr NativeFieldInfoPtr__DrawType;
    private static readonly IntPtr NativeFieldInfoPtr__Curve;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_LinearVector3Curve_PositionDrawType_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772158, RefRangeEnd = 772159, XrefRangeStart = 772156, XrefRangeEnd = 772158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PositionCurveWidget(
      string name,
      LinearVector3Curve curvePtr,
      PositionDrawType drawType,
      Color color)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curvePtr);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &drawType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PositionCurveWidget.NativeMethodInfoPtr__ctor_Public_Void_String_LinearVector3Curve_PositionDrawType_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772159, XrefRangeEnd = 772204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DrawInWorld(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PositionCurveWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PositionCurveWidget()
    {
      Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (PositionCurveWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr);
      PositionCurveWidget.NativeFieldInfoPtr__Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr, nameof (_Color));
      PositionCurveWidget.NativeFieldInfoPtr__DrawType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr, nameof (_DrawType));
      PositionCurveWidget.NativeFieldInfoPtr__Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr, nameof (_Curve));
      PositionCurveWidget.NativeMethodInfoPtr__ctor_Public_Void_String_LinearVector3Curve_PositionDrawType_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr, 100668371);
      PositionCurveWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionCurveWidget>.NativeClassPtr, 100668372);
    }

    public PositionCurveWidget(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color _Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__Color)) = value;
      }
    }

    public unsafe PositionDrawType _DrawType
    {
      get
      {
        return *(PositionDrawType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__DrawType));
      }
      [param: In] set
      {
        *(PositionDrawType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__DrawType)) = value;
      }
    }

    public unsafe LinearVector3Curve _Curve
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__Curve));
        return pointer == IntPtr.Zero ? (LinearVector3Curve) null : new LinearVector3Curve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionCurveWidget.NativeFieldInfoPtr__Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
