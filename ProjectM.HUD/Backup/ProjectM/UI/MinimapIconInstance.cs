// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapIconInstance
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class MinimapIconInstance : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RectTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasRenderer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;

    static MinimapIconInstance()
    {
      Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapIconInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr);
      MinimapIconInstance.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (RectTransform));
      MinimapIconInstance.NativeFieldInfoPtr_CanvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (CanvasRenderer));
      MinimapIconInstance.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (Key));
      MinimapIconInstance.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (Rotation));
      MinimapIconInstance.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (Alpha));
      MinimapIconInstance.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, nameof (Active));
    }

    public MinimapIconInstance(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MinimapIconInstance()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinimapIconInstance>.NativeClassPtr, data));
    }

    public unsafe RectTransform RectTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_RectTransform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasRenderer CanvasRenderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_CanvasRenderer));
        return pointer == System.IntPtr.Zero ? (CanvasRenderer) null : new CanvasRenderer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_CanvasRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MinimapIconKey Key
    {
      get
      {
        return *(MinimapIconKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Key));
      }
      [param: In] set
      {
        *(MinimapIconKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Key)) = value;
      }
    }

    public unsafe Quaternion Rotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe float Alpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Alpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Alpha)) = value;
      }
    }

    public unsafe bool Active
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Active));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapIconInstance.NativeFieldInfoPtr_Active)) = value;
      }
    }
  }
}
