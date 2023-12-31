// Decompiled with JetBrains decompiler
// Type: ProjectM.UpgradeRequirementBuffer
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
  public struct UpgradeRequirementBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public int Stacks;

    public virtual unsafe InventoryBuffer ToInventoryBuffer
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 727514, RefRangeEnd = 727515, XrefRangeStart = 727514, XrefRangeEnd = 727515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeRequirementBuffer.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe PrefabGUID ProjectM\u002EIRequirementBuffer\u002EGuid
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe int ProjectM\u002EIRequirementBuffer\u002EAmount
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static UpgradeRequirementBuffer()
    {
      Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UpgradeRequirementBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr);
      UpgradeRequirementBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, nameof (Guid));
      UpgradeRequirementBuffer.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, nameof (Stacks));
      UpgradeRequirementBuffer.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, 100664703);
      UpgradeRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, 100664704);
      UpgradeRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, 100664705);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpgradeRequirementBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
