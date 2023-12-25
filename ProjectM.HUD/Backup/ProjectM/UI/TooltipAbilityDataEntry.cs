// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipAbilityDataEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipAbilityDataEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipAbilityDataEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipAbilityDataEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipAbilityDataEntry()
    {
      Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipAbilityDataEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr);
      TooltipAbilityDataEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr, nameof (Text));
      TooltipAbilityDataEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr, 100666703);
    }

    public TooltipAbilityDataEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipAbilityDataEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipAbilityDataEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public AssetGuid Text;

      static Data()
      {
        Il2CppClassPointerStore<TooltipAbilityDataEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipAbilityDataEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAbilityDataEntry.Data>.NativeClassPtr);
        TooltipAbilityDataEntry.Data.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAbilityDataEntry.Data>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipAbilityDataEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
