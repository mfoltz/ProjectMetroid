// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeSubMenu_StatsInfoEntry
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
  public class ForgeSubMenu_StatsInfoEntry : GenericSelectionEntry<ForgeSubMenu_StatsInfoEntry.Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235458, XrefRangeEnd = 1235466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Refresh([In] ref ForgeSubMenu_StatsInfoEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ForgeSubMenu_StatsInfoEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235466, XrefRangeEnd = 1235469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForgeSubMenu_StatsInfoEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_StatsInfoEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeSubMenu_StatsInfoEntry()
    {
      Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeSubMenu_StatsInfoEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr);
      ForgeSubMenu_StatsInfoEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr, nameof (Text));
      ForgeSubMenu_StatsInfoEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr, 100665740);
      ForgeSubMenu_StatsInfoEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr, 100665741);
    }

    public ForgeSubMenu_StatsInfoEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_StatsInfoEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_StatsInfoEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AssetGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      [FieldOffset(0)]
      public AssetGuid AssetGuid;
      [FieldOffset(16)]
      public float Value;

      static Data()
      {
        Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry.Data>.NativeClassPtr);
        ForgeSubMenu_StatsInfoEntry.Data.NativeFieldInfoPtr_AssetGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry.Data>.NativeClassPtr, nameof (AssetGuid));
        ForgeSubMenu_StatsInfoEntry.Data.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry.Data>.NativeClassPtr, nameof (Value));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeSubMenu_StatsInfoEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
