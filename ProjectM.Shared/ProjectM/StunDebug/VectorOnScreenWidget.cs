// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.VectorOnScreenWidget
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
  public class VectorOnScreenWidget : DebugWidget
  {
    private static readonly IntPtr NativeFieldInfoPtr_Vector;
    private static readonly IntPtr NativeFieldInfoPtr_Color;
    private static readonly IntPtr NativeFieldInfoPtr_Size;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_Color_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 772205, RefRangeEnd = 772206, XrefRangeStart = 772204, XrefRangeEnd = 772205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VectorOnScreenWidget(string name, Vector2 vector, float size, Color color)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &vector;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &size;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &color;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VectorOnScreenWidget.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetData(Vector2 direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &direction;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VectorOnScreenWidget.NativeMethodInfoPtr_SetData_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772206, XrefRangeEnd = 772233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Rect DrawOnScreen(Rect rect, float z)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &rect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &z;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VectorOnScreenWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num);
    }

    static VectorOnScreenWidget()
    {
      Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (VectorOnScreenWidget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr);
      VectorOnScreenWidget.NativeFieldInfoPtr_Vector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, nameof (Vector));
      VectorOnScreenWidget.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, nameof (Color));
      VectorOnScreenWidget.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, nameof (Size));
      VectorOnScreenWidget.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, 100668376);
      VectorOnScreenWidget.NativeMethodInfoPtr_SetData_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, 100668377);
      VectorOnScreenWidget.NativeMethodInfoPtr_DrawOnScreen_Public_Virtual_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorOnScreenWidget>.NativeClassPtr, 100668378);
    }

    public VectorOnScreenWidget(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2 Vector
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Vector));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Vector)) = value;
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe float Size
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Size));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorOnScreenWidget.NativeFieldInfoPtr_Size)) = value;
      }
    }
  }
}
