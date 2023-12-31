// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupSlotBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGroupSlotBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseAbilityGroupOnSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupSlotEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSlotEntityInitialized_Public_get_Boolean_0;
    [FieldOffset(0)]
    public PrefabGUID BaseAbilityGroupOnSlot;
    [FieldOffset(4)]
    public bool ShowOnBar;
    [FieldOffset(8)]
    public NetworkedEntity GroupSlotEntity;

    public unsafe bool IsSlotEntityInitialized
    {
      [CallerCount(19), CachedScanResults(RefRangeStart = 724780, RefRangeEnd = 724799, XrefRangeStart = 724777, XrefRangeEnd = 724780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityGroupSlotBuffer.NativeMethodInfoPtr_get_IsSlotEntityInitialized_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AbilityGroupSlotBuffer()
    {
      Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupSlotBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr);
      AbilityGroupSlotBuffer.NativeFieldInfoPtr_BaseAbilityGroupOnSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr, nameof (BaseAbilityGroupOnSlot));
      AbilityGroupSlotBuffer.NativeFieldInfoPtr_ShowOnBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr, nameof (ShowOnBar));
      AbilityGroupSlotBuffer.NativeFieldInfoPtr_GroupSlotEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr, nameof (GroupSlotEntity));
      AbilityGroupSlotBuffer.NativeMethodInfoPtr_get_IsSlotEntityInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr, 100664124);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupSlotBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
