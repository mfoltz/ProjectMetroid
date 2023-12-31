// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.PositionWidget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class PositionWidget : DebugWidget
  {
    private static readonly IntPtr NativeFieldInfoPtr__Color;
    private static readonly IntPtr NativeFieldInfoPtr__DrawType;
    private static readonly IntPtr NativeFieldInfoPtr__Positions;
    private static readonly IntPtr NativeMethodInfoPtr_get_PositionList_Public_get_List_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Vector3_PositionDrawType_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0;

    public unsafe List<Vector3> PositionList
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PositionWidget.NativeMethodInfoPtr_get_PositionList_Public_get_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<Vector3>) null : new List<Vector3>(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772158, RefRangeEnd = 772159, XrefRangeStart = 772158, XrefRangeEnd = 772159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PositionWidget(
      string name,
      List<Vector3> posListPtr,
      PositionDrawType drawType,
      Color color)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) posListPtr);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &drawType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PositionWidget.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Vector3_PositionDrawType_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DrawInWorld(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PositionWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PositionWidget()
    {
      Il2CppClassPointerStore<PositionWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (PositionWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr);
      PositionWidget.NativeFieldInfoPtr__Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, nameof (_Color));
      PositionWidget.NativeFieldInfoPtr__DrawType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, nameof (_DrawType));
      PositionWidget.NativeFieldInfoPtr__Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, nameof (_Positions));
      PositionWidget.NativeMethodInfoPtr_get_PositionList_Public_get_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, 100668373);
      PositionWidget.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Vector3_PositionDrawType_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, 100668374);
      PositionWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionWidget>.NativeClassPtr, 100668375);
    }

    public PositionWidget(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color _Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__Color)) = value;
      }
    }

    public unsafe PositionDrawType _DrawType
    {
      get
      {
        return *(PositionDrawType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__DrawType));
      }
      [param: In] set
      {
        *(PositionDrawType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__DrawType)) = value;
      }
    }

    public unsafe List<Vector3> _Positions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__Positions));
        return pointer == IntPtr.Zero ? (List<Vector3>) null : new List<Vector3>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionWidget.NativeFieldInfoPtr__Positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
