// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Focusable
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class Focusable : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnLeftFocusable;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnRightFocusable;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnUpFocusable;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDownFocusable;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasFocus;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFocused_Public_Void_Boolean_Direction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFocused_Protected_Virtual_New_Void_Direction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1278034, RefRangeEnd = 1278053, XrefRangeStart = 1278034, XrefRangeEnd = 1278034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFocused(bool focus, Focusable.Direction direction = Focusable.Direction.None)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &focus;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr_SetFocused_Public_Void_Boolean_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnFocused(Focusable.Direction direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Focusable.NativeMethodInfoPtr_OnFocused_Protected_Virtual_New_Void_Direction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Focusable()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Focusable>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Focusable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Focusable()
    {
      Il2CppClassPointerStore<Focusable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (Focusable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Focusable>.NativeClassPtr);
      Focusable.NativeFieldInfoPtr_OnLeftFocusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, nameof (OnLeftFocusable));
      Focusable.NativeFieldInfoPtr_OnRightFocusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, nameof (OnRightFocusable));
      Focusable.NativeFieldInfoPtr_OnUpFocusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, nameof (OnUpFocusable));
      Focusable.NativeFieldInfoPtr_OnDownFocusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, nameof (OnDownFocusable));
      Focusable.NativeFieldInfoPtr_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Focusable>.NativeClassPtr, nameof (HasFocus));
      Focusable.NativeMethodInfoPtr_SetFocused_Public_Void_Boolean_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100668767);
      Focusable.NativeMethodInfoPtr_OnFocused_Protected_Virtual_New_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100668768);
      Focusable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Focusable>.NativeClassPtr, 100668769);
    }

    public Focusable(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Focusable OnLeftFocusable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnLeftFocusable));
        return pointer == System.IntPtr.Zero ? (Focusable) null : new Focusable(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnLeftFocusable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Focusable OnRightFocusable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnRightFocusable));
        return pointer == System.IntPtr.Zero ? (Focusable) null : new Focusable(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnRightFocusable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Focusable OnUpFocusable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnUpFocusable));
        return pointer == System.IntPtr.Zero ? (Focusable) null : new Focusable(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnUpFocusable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Focusable OnDownFocusable
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnDownFocusable));
        return pointer == System.IntPtr.Zero ? (Focusable) null : new Focusable(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_OnDownFocusable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool HasFocus
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_HasFocus));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Focusable.NativeFieldInfoPtr_HasFocus)) = value;
      }
    }

    public enum Direction
    {
      None,
      Left,
      Right,
      Up,
      Down,
    }
  }
}
