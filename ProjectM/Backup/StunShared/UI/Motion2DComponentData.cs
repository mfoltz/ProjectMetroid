// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DComponentData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace StunShared.UI
{
  public sealed class Motion2DComponentData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_RectTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_Graphics;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextMeshPro;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_LayoutElement;

    static Motion2DComponentData()
    {
      Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DComponentData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr);
      Motion2DComponentData.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (Transform));
      Motion2DComponentData.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (RectTransform));
      Motion2DComponentData.NativeFieldInfoPtr_Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (Graphics));
      Motion2DComponentData.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (Image));
      Motion2DComponentData.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (CanvasGroup));
      Motion2DComponentData.NativeFieldInfoPtr_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (TextMeshPro));
      Motion2DComponentData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (Text));
      Motion2DComponentData.NativeFieldInfoPtr_LayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, nameof (LayoutElement));
    }

    public Motion2DComponentData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Motion2DComponentData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponentData>.NativeClassPtr, data));
    }

    public unsafe Transform Transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Transform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Motion2DComponent<UnityEngine.RectTransform> RectTransform
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_RectTransform);
        return new Motion2DComponent<UnityEngine.RectTransform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.RectTransform>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_RectTransform), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.RectTransform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<Graphic> Graphics
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Graphics));
        return pointer == System.IntPtr.Zero ? (List<Graphic>) null : new List<Graphic>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Graphics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Motion2DComponent<UnityEngine.UI.Image> Image
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Image);
        return new Motion2DComponent<UnityEngine.UI.Image>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.Image>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Image), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.Image>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Motion2DComponent<UnityEngine.CanvasGroup> CanvasGroup
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_CanvasGroup);
        return new Motion2DComponent<UnityEngine.CanvasGroup>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.CanvasGroup>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_CanvasGroup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.CanvasGroup>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Motion2DComponent<TextMeshProUGUI> TextMeshPro
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_TextMeshPro);
        return new Motion2DComponent<TextMeshProUGUI>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<TextMeshProUGUI>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_TextMeshPro), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<TextMeshProUGUI>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Motion2DComponent<UnityEngine.UI.Text> Text
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Text);
        return new Motion2DComponent<UnityEngine.UI.Text>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.Text>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_Text), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.Text>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Motion2DComponent<UnityEngine.UI.LayoutElement> LayoutElement
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_LayoutElement);
        return new Motion2DComponent<UnityEngine.UI.LayoutElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.LayoutElement>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DComponentData.NativeFieldInfoPtr_LayoutElement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DComponent<UnityEngine.UI.LayoutElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
