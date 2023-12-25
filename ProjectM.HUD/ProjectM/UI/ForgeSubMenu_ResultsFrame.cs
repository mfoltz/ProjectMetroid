// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeSubMenu_ResultsFrame
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ForgeSubMenu_ResultsFrame : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfoSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_MagicCircle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResultsMotions;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__StatsInfoCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1235435, RefRangeEnd = 1235436, XrefRangeStart = 1235381, XrefRangeEnd = 1235435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh([In] ref ForgeSubMenu_ResultsFrame.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_ResultsFrame.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235436, XrefRangeEnd = 1235451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForgeSubMenu_ResultsFrame()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_ResultsFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeSubMenu_ResultsFrame()
    {
      Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeSubMenu_ResultsFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr);
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (Button));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (Icon));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (NameText));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_StatsInfoSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (StatsInfoSelectionGroup));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (AbilityGroup));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_MagicCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (MagicCircle));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_ResultsMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (ResultsMotions));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__AbilityCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (_AbilityCache));
      ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__StatsInfoCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (_StatsInfoCache));
      ForgeSubMenu_ResultsFrame.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, 100665735);
      ForgeSubMenu_ResultsFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, 100665736);
    }

    public ForgeSubMenu_ResultsFrame(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_StatsInfoSelectionGroup StatsInfoSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_StatsInfoSelectionGroup));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_StatsInfoSelectionGroup) null : new ForgeSubMenu_StatsInfoSelectionGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_StatsInfoSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_AbilitySelectionGroup AbilityGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_AbilityGroup));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_AbilitySelectionGroup) null : new ForgeSubMenu_AbilitySelectionGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_AbilityGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ForgeSubMenu_MagicCircle MagicCircle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_MagicCircle));
        return pointer == System.IntPtr.Zero ? (ForgeSubMenu_MagicCircle) null : new ForgeSubMenu_MagicCircle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_MagicCircle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ResultsMotions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_ResultsMotions));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr_ResultsMotions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ForgeSubMenu_AbilityEntry.Data> _AbilityCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__AbilityCache));
        return pointer == System.IntPtr.Zero ? (List<ForgeSubMenu_AbilityEntry.Data>) null : new List<ForgeSubMenu_AbilityEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__AbilityCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ForgeSubMenu_StatsInfoEntry.Data> _StatsInfoCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__StatsInfoCache));
        return pointer == System.IntPtr.Zero ? (List<ForgeSubMenu_StatsInfoEntry.Data>) null : new List<ForgeSubMenu_StatsInfoEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.NativeFieldInfoPtr__StatsInfoCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Level;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
      private static readonly System.IntPtr NativeFieldInfoPtr_StatsInfo;
      private static readonly System.IntPtr NativeFieldInfoPtr_FirstFrame;

      static Data()
      {
        Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr);
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (Icon));
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (Name));
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (Level));
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (SpellMods));
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_StatsInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (StatsInfo));
        ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_FirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, nameof (FirstFrame));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeSubMenu_ResultsFrame.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe float Level
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Level));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_Level)) = value;
        }
      }

      public unsafe List<SpellModInfo> SpellMods
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_SpellMods));
          return pointer == System.IntPtr.Zero ? (List<SpellModInfo>) null : new List<SpellModInfo>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_SpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public StatsInfo StatsInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_StatsInfo);
          return new StatsInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_StatsInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool FirstFrame
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_FirstFrame));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_ResultsFrame.Data.NativeFieldInfoPtr_FirstFrame)) = value;
        }
      }
    }
  }
}
