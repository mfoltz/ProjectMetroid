// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UIHighlightData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class UIHighlightData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AllAbilitiesUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitiesUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShapeShiftsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildingsViewed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesViewed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchViewed;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodsViewed;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitiesViewed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShapeShiftsViewed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1289002, RefRangeEnd = 1289004, XrefRangeStart = 1288969, XrefRangeEnd = 1289002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIHighlightData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIHighlightData()
    {
      Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UIHighlightData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr);
      UIHighlightData.NativeFieldInfoPtr_AllAbilitiesUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (AllAbilitiesUnlocked));
      UIHighlightData.NativeFieldInfoPtr_AbilitiesUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (AbilitiesUnlocked));
      UIHighlightData.NativeFieldInfoPtr_ShapeShiftsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (ShapeShiftsUnlocked));
      UIHighlightData.NativeFieldInfoPtr_BuildingsViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (BuildingsViewed));
      UIHighlightData.NativeFieldInfoPtr_RecipesViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (RecipesViewed));
      UIHighlightData.NativeFieldInfoPtr_ResearchViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (ResearchViewed));
      UIHighlightData.NativeFieldInfoPtr_VBloodsViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (VBloodsViewed));
      UIHighlightData.NativeFieldInfoPtr_AbilitiesViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (AbilitiesViewed));
      UIHighlightData.NativeFieldInfoPtr_ShapeShiftsViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, nameof (ShapeShiftsViewed));
      UIHighlightData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightData>.NativeClassPtr, 100669723);
    }

    public UIHighlightData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int AllAbilitiesUnlocked
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AllAbilitiesUnlocked));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AllAbilitiesUnlocked)) = value;
      }
    }

    public unsafe int AbilitiesUnlocked
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AbilitiesUnlocked));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AbilitiesUnlocked)) = value;
      }
    }

    public unsafe int ShapeShiftsUnlocked
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ShapeShiftsUnlocked));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ShapeShiftsUnlocked)) = value;
      }
    }

    public unsafe List<int> BuildingsViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_BuildingsViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_BuildingsViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> RecipesViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_RecipesViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_RecipesViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> ResearchViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ResearchViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ResearchViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> VBloodsViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_VBloodsViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_VBloodsViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> AbilitiesViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AbilitiesViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_AbilitiesViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> ShapeShiftsViewed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ShapeShiftsViewed));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightData.NativeFieldInfoPtr_ShapeShiftsViewed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
