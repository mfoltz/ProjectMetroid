// Decompiled with JetBrains decompiler
// Type: ProjectM.IRecipeUser
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace ProjectM
{
  public class IRecipeUser : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Abstract_Virtual_New_get_List_1_RecipeDataAsset_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRecipeUser.NativeMethodInfoPtr_get_UsedRecipes_Public_Abstract_Virtual_New_get_List_1_RecipeDataAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    static IRecipeUser()
    {
      Il2CppClassPointerStore<IRecipeUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IRecipeUser));
      IRecipeUser.NativeMethodInfoPtr_get_UsedRecipes_Public_Abstract_Virtual_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRecipeUser>.NativeClassPtr, 100676646);
    }

    public IRecipeUser(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
