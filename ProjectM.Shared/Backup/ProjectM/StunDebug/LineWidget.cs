// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.LineWidget
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
  public class LineWidget : DebugWidget
  {
    private static readonly IntPtr NativeFieldInfoPtr__Name;
    private static readonly IntPtr NativeFieldInfoPtr__Color;
    private static readonly IntPtr NativeFieldInfoPtr__StartPosition;
    private static readonly IntPtr NativeFieldInfoPtr__EndPosition;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Vector3_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772124, XrefRangeEnd = 772126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LineWidget(string name, Color color)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineWidget>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineWidget.NativeMethodInfoPtr__ctor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetData(Vector3 startPos, Vector3 endPos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &startPos;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &endPos;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LineWidget.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772126, XrefRangeEnd = 772139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Rect DrawOnScreen(Rect rect, float z)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &rect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &z;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LineWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772139, XrefRangeEnd = 772156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DrawInWorld(Camera camera)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LineWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LineWidget()
    {
      Il2CppClassPointerStore<LineWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (LineWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineWidget>.NativeClassPtr);
      LineWidget.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, nameof (_Name));
      LineWidget.NativeFieldInfoPtr__Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, nameof (_Color));
      LineWidget.NativeFieldInfoPtr__StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, nameof (_StartPosition));
      LineWidget.NativeFieldInfoPtr__EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, nameof (_EndPosition));
      LineWidget.NativeMethodInfoPtr__ctor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, 100668367);
      LineWidget.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, 100668368);
      LineWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, 100668369);
      LineWidget.NativeMethodInfoPtr_DrawInWorld_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineWidget>.NativeClassPtr, 100668370);
    }

    public LineWidget(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__Name)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Color _Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__Color)) = value;
      }
    }

    public unsafe Vector3 _StartPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__StartPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__StartPosition)) = value;
      }
    }

    public unsafe Vector3 _EndPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__EndPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineWidget.NativeFieldInfoPtr__EndPosition)) = value;
      }
    }
  }
}
