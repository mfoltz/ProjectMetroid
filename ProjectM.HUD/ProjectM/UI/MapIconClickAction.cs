// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapIconClickAction
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public sealed class MapIconClickAction : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Action;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAction_Public_get_Boolean_0;

    public unsafe bool HasAction
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapIconClickAction.NativeMethodInfoPtr_get_HasAction_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static MapIconClickAction()
    {
      Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapIconClickAction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr);
      MapIconClickAction.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, nameof (Button));
      MapIconClickAction.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, nameof (Modifiers));
      MapIconClickAction.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, nameof (Action));
      MapIconClickAction.NativeMethodInfoPtr_get_HasAction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, 100667711);
    }

    public MapIconClickAction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MapIconClickAction()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, data));
    }

    public unsafe PointerEventData.InputButton Button
    {
      get
      {
        return *(PointerEventData.InputButton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Button));
      }
      [param: In] set
      {
        *(PointerEventData.InputButton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Button)) = value;
      }
    }

    public unsafe ModifierButtons Modifiers
    {
      get
      {
        return *(ModifierButtons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Modifiers));
      }
      [param: In] set
      {
        *(ModifierButtons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Modifiers)) = value;
      }
    }

    public unsafe Il2CppSystem.Action Action
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Action));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapIconClickAction.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
