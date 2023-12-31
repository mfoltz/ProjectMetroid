// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ButtonTarget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class ButtonTarget : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Transition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Colors;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpriteState;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationTriggers;
    private static readonly System.IntPtr NativeFieldInfoPtr_FontState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphicTargets;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795489, XrefRangeEnd = 795508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ButtonTarget()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ButtonTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ButtonTarget()
    {
      Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (ButtonTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr);
      ButtonTarget.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (Enabled));
      ButtonTarget.NativeFieldInfoPtr_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (Transition));
      ButtonTarget.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (Colors));
      ButtonTarget.NativeFieldInfoPtr_SpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (SpriteState));
      ButtonTarget.NativeFieldInfoPtr_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (AnimationTriggers));
      ButtonTarget.NativeFieldInfoPtr_FontState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (FontState));
      ButtonTarget.NativeFieldInfoPtr_GraphicTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, nameof (GraphicTargets));
      ButtonTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonTarget>.NativeClassPtr, 100670202);
    }

    public ButtonTarget(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Enabled)) = value;
      }
    }

    public unsafe Transition Transition
    {
      get
      {
        return *(Transition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Transition));
      }
      [param: In] set
      {
        *(Transition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Transition)) = value;
      }
    }

    public unsafe ColorBlock Colors
    {
      get
      {
        return *(ColorBlock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Colors));
      }
      [param: In] set
      {
        *(ColorBlock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_Colors)) = value;
      }
    }

    public SpriteState SpriteState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_SpriteState);
        return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_SpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AnimationTriggers AnimationTriggers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_AnimationTriggers));
        return pointer == System.IntPtr.Zero ? (AnimationTriggers) null : new AnimationTriggers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FontState FontState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_FontState);
        return new FontState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_FontState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppReferenceArray<Graphic> GraphicTargets
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_GraphicTargets));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Graphic>) null : new Il2CppReferenceArray<Graphic>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonTarget.NativeFieldInfoPtr_GraphicTargets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
