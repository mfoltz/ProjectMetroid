// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.SetToggleFriendsKeyOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetToggleFriendsKeyOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__KeyCombination_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyCombination_Public_get_KeyCombination_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_KeyCombination_Public_set_Void_KeyCombination_0;
    [FieldOffset(0)]
    public KeyCombination _KeyCombination_k__BackingField;

    public unsafe KeyCombination KeyCombination
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetToggleFriendsKeyOptions.NativeMethodInfoPtr_get_KeyCombination_Public_get_KeyCombination_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(KeyCombination*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetToggleFriendsKeyOptions.NativeMethodInfoPtr_set_KeyCombination_Public_set_Void_KeyCombination_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SetToggleFriendsKeyOptions()
    {
      Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (SetToggleFriendsKeyOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr);
      SetToggleFriendsKeyOptions.NativeFieldInfoPtr__KeyCombination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr, "<KeyCombination>k__BackingField");
      SetToggleFriendsKeyOptions.NativeMethodInfoPtr_get_KeyCombination_Public_get_KeyCombination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr, 100665320);
      SetToggleFriendsKeyOptions.NativeMethodInfoPtr_set_KeyCombination_Public_set_Void_KeyCombination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr, 100665321);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetToggleFriendsKeyOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
