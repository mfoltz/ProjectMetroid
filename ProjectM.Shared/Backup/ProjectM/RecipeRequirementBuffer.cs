// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeRequirementBuffer
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
  public struct RecipeRequirementBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public int Amount;

    public virtual unsafe InventoryBuffer ToInventoryBuffer
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 727514, RefRangeEnd = 727515, XrefRangeStart = 727514, XrefRangeEnd = 727514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeRequirementBuffer.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static RecipeRequirementBuffer()
    {
      Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RecipeRequirementBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr);
      RecipeRequirementBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr, nameof (Guid));
      RecipeRequirementBuffer.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr, nameof (Amount));
      RecipeRequirementBuffer.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr, 100664403);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeRequirementBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
