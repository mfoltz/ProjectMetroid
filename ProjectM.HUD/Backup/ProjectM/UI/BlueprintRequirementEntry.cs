// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BlueprintRequirementEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BlueprintRequirementEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequirementsText;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlueprintRequirementEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlueprintRequirementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlueprintRequirementEntry()
    {
      Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BlueprintRequirementEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr);
      BlueprintRequirementEntry.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr, nameof (ItemIcon));
      BlueprintRequirementEntry.NativeFieldInfoPtr_RequirementsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr, nameof (RequirementsText));
      BlueprintRequirementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr, 100664803);
    }

    public BlueprintRequirementEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image ItemIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.NativeFieldInfoPtr_ItemIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI RequirementsText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.NativeFieldInfoPtr_RequirementsText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.NativeFieldInfoPtr_RequirementsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_ObtainedAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequiredAmount;

      static Data()
      {
        Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintRequirementEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr);
        BlueprintRequirementEntry.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr, nameof (Icon));
        BlueprintRequirementEntry.Data.NativeFieldInfoPtr_ObtainedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr, nameof (ObtainedAmount));
        BlueprintRequirementEntry.Data.NativeFieldInfoPtr_RequiredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr, nameof (RequiredAmount));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintRequirementEntry.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int ObtainedAmount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_ObtainedAmount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_ObtainedAmount)) = value;
        }
      }

      public unsafe int RequiredAmount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_RequiredAmount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintRequirementEntry.Data.NativeFieldInfoPtr_RequiredAmount)) = value;
        }
      }
    }
  }
}
